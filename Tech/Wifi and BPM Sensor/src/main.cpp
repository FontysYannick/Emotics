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

dht TempSensor;

#define DHT11_PIN 7
///Pins (BPMSensor, RGB, Button, LCD)////////////////////////////////////////////////////
const int PulseSensorPin = A3; //pin voor hartslag sensor
const int RGBGreen = A2;
const int RGBRed = A1;
const int RGBBlue = A0;
const int Button = 1;

LiquidCrystal lcd(13, 11, 5, 4, 3, 2); //pins voor lcd scherm
///Normal variable for button////////////////////////////////////////////////////////////

int LastButtonState = 0;
int ButtonState = 0;

bool SportModus = false; // voor sportstand

///Debounce/Delay////////////////////////////////////////////////////////////////////////
unsigned long EventTime = 60000;
unsigned long PreviousTime = 0;
unsigned long CurrentTime = millis();

///ID and WW for Wifi////////////////////////////////////////////////////////////////////

//char SSID[] = "MSI9247"; //mobiele hotspot van laptop naam
//char PASS[] = "gr3wt2h64"; //mobiele hotspot ww

char SSID[] = "LAPTOP-TGTISK9B 1790";
char PASS[] = "955Y1n51";

int status = WL_IDLE_STATUS; //Wifi status
///Database//////////////////////////////////////////////////////////////////////////////



///Heartbeat/////////////////////////////////////////////////////////////////////////////

int BPM;  //map function voor BPM
int avgBPM; //
unsigned long MinuteBPM[60];
///Timer////////////////////////////////////////////////////////////////////////////////

int Second = 0;
int Minute = 0;
int Hour = 0;

const unsigned long eventTimeMinute = 60000; //60000
unsigned long previousTimeMinute = 0;
const unsigned long eventTimeSecond = 1000;
unsigned long previousTimeSecond = 0;

////////////////////////////////////////////////////////////////////////////////////////

void SendData()
{
	WiFiClient client;

byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };

String BPMDATA = "349";
String O2 = "99";
String Temp = "1000";

int    HTTP_PORT   = 80;
String HTTP_METHOD = "GET";
char   HOST_NAME[] = "192.168.2.157"; // change to your PC's IP address
String PATH_NAME   = "/insert_temp.php";
String queryString = "?BPM=" + BPMDATA + "&Temp=" + Temp + "&O2=" + O2;

  if(client.connect(HOST_NAME, HTTP_PORT)) {
    // if connected:
    Serial.println("Connected to server");
    // make a HTTP request:
    // send HTTP header
    client.println(HTTP_METHOD + " " + PATH_NAME + queryString + "HTTP/1.1");
    client.println("Host: " + String(HOST_NAME));
    client.println("Connection: close");
    client.println(); // end HTTP header

    while(client.connected()) {
      if(client.available()){
        // read an incoming byte from the server and print it to serial monitor:
        char c = client.read();
        Serial.print(c);
      }
    }

    // the server's disconnected, stop the client:
    client.stop();
    Serial.println();
    Serial.println("disconnected");
  } else {// if not connected:
    Serial.println("connection failed");
  }

}

void time()
{
	  unsigned long currentTimeMinute = millis();
	   if(currentTimeMinute - previousTimeMinute >= eventTimeMinute)
  {
    SendData();
	previousTimeMinute = currentTimeMinute;
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
		time();
	}
	if (Second >= 10)
	{
		lcd.setCursor(8,0);
		if (SportModus == HIGH)
		{
			lcd.print("Sprt:ON ");
		}
		else {
			lcd.print("Sprt:OFF");	
		}
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

	Second ++;
}

void setup() 
{

///Begin lcd and Serial/////////////////////////////////////////////////////////////////
	lcd.begin(16, 2, 32);
	Serial.begin(9600);
	pinMode(RGBRed, OUTPUT);
	pinMode(RGBBlue, OUTPUT);
	pinMode(RGBGreen, OUTPUT);
///Connect to wifi//////////////////////////////////////////////////////////////////////
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
	delay(1200);
///Time to LCD screen///////////////////////////////////////////////////////////////////
	lcd.setCursor(0, 1);
	lcd.print("Timer : 00.00.00");
	lcd.setCursor(13,1);
	lcd.setCursor(8,0);
		if (SportModus == HIGH)
		{
			lcd.print("Sprt:ON ");
		}
		else {
			lcd.print("Sprt:OFF");	
		}

///Start time set on 0//////////////////////////////////////////////////////////////////
	Second = 0;
	Minute = 0;
///Button is input//////////////////////////////////////////////////////////////////////
	pinMode(Button, INPUT); 

////////////////////////////

}


void loop()
{
///Temperature sensor/////////////////////////////////////////////////////////////////////////
	double chk = TempSensor.read11(DHT11_PIN);
///BPM to BPM variable//////////////////////////////////////////////////////////////////
	BPM = map(analogRead(PulseSensorPin), 0, 1000, 0, 100);
///LCD en Serial print waardes/////////////////////////////////////////////////////////////////
	lcd.setCursor(0, 0);
	lcd.print("BPM: ");
	lcd.print(BPM);

	Serial.print("Temperature : ");
	Serial.println(TempSensor.temperature);
	Serial.print("Humidity : ");
	Serial.println(TempSensor.humidity);
///Timer showing on LCD screen//////////////////////////////////////////////////////////
void klok(){
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
	
	if (Second >= 10)
	{
		lcd.setCursor(8,0);
		
		if (SportModus == HIGH)
		{
			lcd.print("Sprt:ON ");
		}
		else {
			lcd.print("Sprt:OFF");	
		}
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

void loop()
{
///BPM to BPM variable//////////////////////////////////////////////////////////////////
	BPM = map(analogRead(PulseSensorPin), 0, 1000, 0, 100);

	double chk = TempSensor.read11(DHT11_PIN);

	Serial.print("Temperature : ");
	Serial.println(TempSensor.temperature);
	Serial.print("Humidity : ");
	Serial.println(TempSensor.humidity);
///LCD print BPM waarde/////////////////////////////////////////////////////////////////
	lcd.setCursor(0, 0);
	lcd.print("BPM: ");
	lcd.print(BPM);

///Timer showing on LCD screen//////////////////////////////////////////////////////////

	klok();
	delay(1000);//moet eig naar millis
	
///Sport mode, if you are active you're heartbeat is not send to the database////////////
	ButtonState = digitalRead(Button);

	if (ButtonState == HIGH) 
	{

 		SportModus = !SportModus;
	}
	if (SportModus == HIGH)
	{
		Serial.println("Sport Modus : ON");
	}
	else {
		Serial.println("Sport Modus : OFF");
		//SendData();
	}

///Saving BPM for later use as avarage//////////////////////////////////////////////////

if (BPM >= 0)
{
	avgBPM = avgBPM + BPM;
}
///Printing avarage BPM/////////////////////////////////////////////////////////////////
if (Second >= 60)
{
	Serial.print("avgBPM : ");
	Serial.println(avgBPM / 60);
}

///Database connectie en doorsturen/////////////////////////////////////////////////////

time();

///rgb gedoe////

map(RGBRed, 0, 255, 0, 100);
map(RGBGreen, 0, 255, 0, 100);
map(RGBBlue, 0, 255, 0, 100);
digitalWrite(RGBRed, 90);
digitalWrite(RGBBlue, 90);
digitalWrite(RGBGreen, 0);

///Wanneer min voorbij dan data naar database////////////////////////////////////////////

}
//Kan nog handig zijn
//int a = 10;
//char *intStr = itoa(a);
//String str = String(intStr);