///Librarys//////////////////////////////////////////////////////////////////////
#include <Arduino.h>
#include <PulseSensorPlayground.h>
#include <WiFiNINA.h>
#include <LiquidCrystal.h>
#include <SPI.h>
#include <ArduinoHttpClient.h>
#include <ArduinoJson.h>
///Pins (BPMSensor, RGB, Button, LCD)////////////////////////////////////////////////////
const int PulseSensorPin = A5; //pin voor hartslag sensor
const int RGBRed = 10;
const int RGBGreen = 9;
const int RGBBlue = 8;
const int Button = 1;

LiquidCrystal lcd(12, 11, 5, 4, 3, 2); //pins voor lcd scherm
///Normal variable for button////////////////////////////////////////////////////////////

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

const char server[] = "studmysql01.fhict.local"; 
int clientId = 0;

WiFiClient wifi;
HttpClient client = HttpClient(wifi, server, 2435);

///Heartbeat/////////////////////////////////////////////////////////////////////////////

int BPM;  //map function voor BPM
int avgBPM; //
unsigned long MinuteBPM[60];
///Timer////////////////////////////////////////////////////////////////////////////////

int Second = 0;
int Minute = 0;
int Hour = 0;

////////////////////////////////////////////////////////////////////////////////////////

void setup() 
{

///Begin lcd and Serial/////////////////////////////////////////////////////////////////
	lcd.begin(16, 2, 32);
	Serial.begin(9600);
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
	lcd.print("Time past:  0.00");
	lcd.setCursor(13,1);

///Start time set on 0//////////////////////////////////////////////////////////////////
	Second = 0;
	Minute = 0;
///Button is input//////////////////////////////////////////////////////////////////////
	pinMode(Button, INPUT); 

////////////////////////////

 int temp;
temp = 1;

client.print(temp);
Serial.print("Yeah... it ain't holding");
 //int temp = 4;
 // int humid = 5;

  if (client.connect("studmysql01.fhict.local", 80))
  {
    // REPLACE WITH YOUR SERVER ADDRESS
    Serial.println("connected");
    client.println("GET /insertmysql.php?temp=");
    //client.println("?temp=");
    client.println("4");
    //client.println("Humid=");
    //client.println(humid);
    client.println(" HTTP/1.1");
    client.println("Host: 10.0.0.56");
    //client.println("Content-Type: application/x-www-form-urlencoded; charset=UTF-8");
    client.println();
    //client.print(query);
    //client.print("Content-Length: ");
    //int thisLength = query.length();
    //client.println(thisLength);
    
  }
  delay(2000);
  Serial.println("Response: ");
  while (client.connected() || client.available())
  {
    Serial.write(client.read());
  }
delay(10000);
}




void SendData() {
/*void registerArduino() {
  StaticJsonDocument<8> json;

  json["tafelNummer"] = 1;

  String data;
  serializeJson(json, data);

  client.beginRequest();
  client.post("/register", "application/json", data);

  if(client.responseStatusCode() == 200) {
    StaticJsonDocument<24> response;
    deserializeJson(response, client.responseBody());
    clientId = response["id"];
  }
}

void updateAmperage() {
  	StaticJsonDocument<16> json;

  	json["clientId"] = clientId;
  	json[BPM] = 100;

 	String data;
  	serializeJson(json, data);

	client.beginRequest();
  	client.post("/emotietabel", "application/json", data);

  	if(client.responseStatusCode() == 406) {
    	registerArduino();
  	}
}

	if (CurrentTime - PreviousTime >= EventTime)
	{
		registerArduino();
	}
	
	if (CurrentTime - PreviousTime >= EventTime)
	{
	updateAmperage();
	client.print("Test");
	}

	if(client.connect(server, 3306)) {
		client.print("GET /write_data.php?");
		client.print("value=");
		client.print(Signaal / 10);
		client.println(" HTTP/1.1"); 
		client.println("Host: 192.168.137.207");
		client.println("Connection: close");
		client.println();
		client.println();
		client.stop();
  }
  else {

    Serial.println("--> connection failed\n");
  }*/

}


void loop()
{
///BPM to BPM variable//////////////////////////////////////////////////////////////////
	BPM = map(analogRead(PulseSensorPin), 0, 1000, 0, 100);
///LCD print BPM waarde/////////////////////////////////////////////////////////////////
	lcd.setCursor(0, 0);
	lcd.print("BPM: ");
	lcd.print(BPM);

///Timer showing on LCD screen//////////////////////////////////////////////////////////
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
		lcd.setCursor(9, 0);
		lcd.print("avg: ");
		lcd.print(avgBPM / 60);
		avgBPM = 0; //avarage BPM reset
	}

	if (Minute > 9)
	{
		lcd.setCursor(11, 1);
		lcd.print(Minute);
		lcd.setCursor(13,1);
		lcd.print(".");
	}

	Serial.print("Min : ");
	Serial.println(Minute);

	Serial.print("Sec : ");
	Serial.println(Second);

	Serial.print("BPM : ");
	Serial.println(BPM);

	Serial.println("");

	Second ++;

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
		SendData();
	}

///Saving BPM for later use as avarage//////////////////////////////////////////////////

if (BPM >= 0)
{
	MinuteBPM[Second] = BPM;
	avgBPM = avgBPM + BPM;
	Serial.println(avgBPM);

}
///Printing avarage BPM/////////////////////////////////////////////////////////////////
if (Second >= 60)
{
	Serial.print("avgBPM : ");
	Serial.println(avgBPM / 60);
	MinuteBPM[Second] = 0;
	BPM = 0;

}
///Database connectie en doorsturen/////////////////////////////////////////////////////
}