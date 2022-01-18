///Librarys//////////////////////////////////////////////////////////////////////
#include <Arduino.h>
#include <PulseSensorPlayground.h>
#include <WiFiNINA.h>
#include <LiquidCrystal.h>
#include <SPI.h>
#include <ArduinoHttpClient.h>
#include <ArduinoJson.h>
#include <dht.h>
#include <Adafruit_Sensor.h>

///Pins (BPMSensor, RGB, Button, LCD)////////////////////////////////////////////////////

const int PulseSensorPin = A3; //pin voor hartslag sensor

const int RGBGreen = A2;  
const int RGBRed = A1;
const int RGBBlue = A0;

const int Button = 1;

LiquidCrystal lcd(13, 11, 5, 4, 3, 2); //pins voor lcd scherm

#define DHT11_PIN 7
dht TempSensor;

///Normal variable for button////////////////////////////////////////////////////////////

int ButtonState = 0;
int LastButtonState = 0;

bool SportModus = false; // voor sportstand

///ID and WW for Wifi////////////////////////////////////////////////////////////////////

//char SSID[] = "MSI9247"; //mobiele hotspot van laptop naam
//char PASS[] = "gr3wt2h64"; //mobiele hotspot ww

char SSID[] = "LAPTOP-TGTISK9B 1790";
char PASS[] = "955Y1n51";

int status = WL_IDLE_STATUS; //Wifi status

///Database//////////////////////////////////////////////////////////////////////////////

//int temperature = TempSensor.temperature;//naar kijken want 0.00
int oxygen = TempSensor.humidity;

///Heartbeat/////////////////////////////////////////////////////////////////////////////

int BPM;  //BPM for sensor
int avgBPM; //average BPM 
unsigned long MinuteBPM[60];

///Timer////////////////////////////////////////////////////////////////////////////////

//start for clock
int Second = 0;
int Minute = 0;
int Hour = 0;
//

//seconds for clock
const unsigned long eventTimeSecond = 1000;
unsigned long previousTimeSecond = 0;
//

//timeSendData
const unsigned long eventTimeMinute = 20000; //60000
unsigned long previousTimeMinute = 0;
//

////////////////////////////////////////////////////////////////////////////////////////

void wifiConnect()
{
	while (status != WL_CONNECTED)
  	{
   		Serial.print("Connecting to WiFi");
    	delay(200);
		Serial.print(".");
		delay(200);
		Serial.print(".");
		delay(200);
		Serial.println(".");
		delay(200);
		status = WiFi.begin(SSID, PASS);
  	}

 	Serial.println("Connected to the WiFi network");
 	Serial.println(WiFi.localIP());
}

void SendData()
{

WiFiClient client;

byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };


int    HTTP_PORT   = 80;
String HTTP_METHOD = "GET";
char   HOST_NAME[] = "192.168.137.1"; // change to your PC's IP address
String PATH_NAME   = "/insert_temp.php";
String queryStringBPM = "?BPM=";
String queryStringTemp = "&Temp=";
String queryStringO2 = "&O2=";


  if(client.connect(HOST_NAME, HTTP_PORT)) 
  {
    // if connected:
    Serial.println("Connected to server");

	double temperatuuuuur = map(TempSensor.temperature, 0, 50, 35, 39);
	int oxygeeeeeeeeen = map(TempSensor.humidity, 0, 100, 90, 100);
    // make a HTTP request:
    // send HTTP header
    client.println(HTTP_METHOD + " " + PATH_NAME + queryStringBPM + BPM + queryStringTemp + temperatuuuuur + queryStringO2 + oxygeeeeeeeeen + "HTTP/1.1");
    client.println("Host: " + String(HOST_NAME));
    client.println("Connection: close");
    client.println(); // end HTTP header

    while(client.connected()) 
	{
      if(client.available())
	  {
        // read an incoming byte from the server and print it to serial monitor:
        char c = client.read();
        Serial.print(c);
      }
    }

    // the server's disconnected, stop the client:
    client.stop();
	Serial.println("");
    Serial.println("disconnected");
  } 
  
  else 
  {// if not connected:
    Serial.println("connection failed");
  }

}

void timeSendData()
{
	unsigned long currentTimeMinute = millis();

	if(currentTimeMinute - previousTimeMinute >= eventTimeMinute)
	{
    SendData();
	previousTimeMinute = currentTimeMinute;
	}
}

void clock()
{

	unsigned long currentTimeSecond = millis();
	
	if (currentTimeSecond - previousTimeSecond >= eventTimeSecond)
	{
		Second++;
	}
	
	if (Second < 10)
	{
		lcd.setCursor(15,1);
		lcd.print(Second);
		lcd.setCursor(14,1);
		lcd.print("0");
	}

	else 
	{
		lcd.setCursor(14,1);
		lcd.print(Second);	
	}

	if (Second >= 10)
	{
		lcd.setCursor(8,0);
		
		if (SportModus == HIGH)
		{
			lcd.print("Sprt:ON ");
		}
		else 
		{
			lcd.print("Sprt:OFF");	
		}
	}
	
	if (Second >= 60)
	{
		Second = 0;
		Minute ++;

		lcd.setCursor(14,1);
		lcd.print("00");
		lcd.setCursor(12,1);
		lcd.print(Minute);
		lcd.setCursor(8,0);
		lcd.print("avg: ");
		lcd.print(avgBPM / 60);
		lcd.setCursor(15,0);
		lcd.print(" ");
		avgBPM = 0; //avarage BPM reset
	}
	
	if (Minute > 9)
	{
		lcd.setCursor(11, 1);
		lcd.print(Minute);
		lcd.setCursor(13,1);
		lcd.print(".");
	}
	
	if (Minute >= 60)
	{
		Second = 0;
		Minute = 0;
		Hour ++;

		lcd.setCursor(14,1);
		lcd.print("00");
		lcd.setCursor(11,1);
		lcd.print("00");
		lcd.setCursor(15,0);
		lcd.print(" ");
		lcd.setCursor(9,1);
		lcd.print(Hour);
	
	}
	
	if (Hour > 9)
	{
		lcd.setCursor(8, 1);
		lcd.print(Hour);
		lcd.setCursor(10,1);
		lcd.print(".");
	}
	
	Serial.print("Hour : ");
	Serial.println(Hour);

	Serial.print("Min : ");
	Serial.println(Minute);

	Serial.print("Sec : ");
	Serial.println(Second);

	Serial.print("BPM : ");
	Serial.println(BPM);

	Serial.println("");
}

void setup() 
{
///Begin lcd and Serial/////////////////////////////////////////////////////////////////

	lcd.begin(16, 2, 32);
	Serial.begin(9600);

///Connect to wifi//////////////////////////////////////////////////////////////////////

	wifiConnect();

///Preset LCD///////////////////////////////////////////////////////////////////

	lcd.setCursor(0, 1);
	lcd.print("Timer : 00.00.00");

	lcd.setCursor(8,0);

	if (SportModus == HIGH)
	{
		lcd.print("Sprt:ON ");
	}
	else {
		lcd.print("Sprt:OFF");	
	}

///Start time on 0//////////////////////////////////////////////////////////////////////

	Second = 0;
	Minute = 0;

///I/O//////////////////////////////////////////////////////////////////////////////////

	pinMode(Button, INPUT); 

	pinMode(RGBRed, OUTPUT);
	pinMode(RGBBlue, OUTPUT);
	pinMode(RGBGreen, OUTPUT);

}

void loop()
{
///BPM map//////////////////////////////////////////////////////////////////

	BPM = map(analogRead(PulseSensorPin), 0, 1000, 0, 100);

///Reading Temperature and Humidity, then printing in serial////////////////

	double chk = TempSensor.read11(DHT11_PIN);

	Serial.print("Temperature : ");
	Serial.println(TempSensor.temperature);
	Serial.print("Humidity : ");
	Serial.println(TempSensor.humidity);

///calculating and printing average BPM//////////////////////////////////////////////////

	if (BPM >= 0)
	{
		avgBPM = avgBPM + BPM;
	}

	if (Second >= 60)
	{
		Serial.print("avgBPM : ");
		Serial.println(avgBPM / 60);
	}

		lcd.setCursor(0, 0);
		lcd.print("BPM: ");
		lcd.print(BPM);

///clock showing on LCD screen//////////////////////////////////////////////

	clock();
	delay(1000); // snap niet waarom dit ding er is
	
///Sport mode, if you are active you're data is not send to the database

	ButtonState = digitalRead(Button);

	if (ButtonState == HIGH) 
	{

 		SportModus = !SportModus;
	}
	if (SportModus == HIGH)
	{
		Serial.println("Sport Modus : ON");
	}
	else 
	{
		Serial.println("Sport Modus : OFF");
		timeSendData();
	}

///rgb gedoe////

map(RGBRed, 0, 255, 0, 100);
map(RGBGreen, 0, 255, 0, 100);
map(RGBBlue, 0, 255, 0, 100);
digitalWrite(RGBRed, 90);
digitalWrite(RGBBlue, 90);
digitalWrite(RGBGreen, 0);

}
///Mogelijk komt er nog een deel 2///////////////////////////////////////////////////////