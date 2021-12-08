#include <Arduino.h>
#include <PulseSensorPlayground.h>
#include <WiFiNINA.h>
#include <LiquidCrystal.h>
#include <SPI.h>
#include <ArduinoHttpClient.h>
#include <ArduinoJson.h>


const int PulseSensorPurplePin = 0; //pin voor hartslag sensor
LiquidCrystal lcd(12, 11, 5, 4, 3, 2); //pins voor lcd scherm

unsigned long EventTime = 60000;
unsigned long PreviousTime = 0;
unsigned long CurrentTime = millis();

//char SSID[] = "MSI9247"; //mobiele hotspot van laptop naam
//char PASS[] = "gr3wt2h64"; //mobiele hotspot ww

char SSID[] = "LAPTOP-TGTISK9B 1790";
char PASS[] = "955Y1n51";

const char server[] = "studmysql01.fhict.local"; //database

int status = WL_IDLE_STATUS; //Wifi status

WiFiClient wifi;
HttpClient client = HttpClient(wifi, server, 2435);

int Signal; //signaal wat van hartslag sensor afkomt
int BPM;  //map function voor BPM
int gemBPM[60];

int clientId = 0;

int Second = 0;
int Minute = 0;
int Hour = 0;

const int Button = 9; // voor sportstand
int ButtonState = 0; // voor sportstand
bool SportModus = false; // voor sportstand



void setup() 
{
	lcd.begin(16, 2, 32);
	Serial.begin(9600);
	
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

	lcd.setCursor(0, 1);
	lcd.print("Time past:  0.00");
	lcd.setCursor(13,1);
	Second = 0;
	Minute = 0;

	

	pinMode(Button, INPUT); //voor sportstand
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
	Signal = analogRead(PulseSensorPurplePin);
	BPM = map(Signal, 0, 1000, 0, 100);

	lcd.setCursor(0, 0);
	lcd.print("BPM <3: ");
	lcd.print(BPM);

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
	Serial.println(Signal / 10);

	Serial.println("");

	Second ++;

	delay(1000);
	/*
	int gemBPM[60] = { };
	int Count;
	int AVG = 0;
	for (Count = 0; Count < 1; Count++)
	{
		gemBPM[Count] = BPM;
		AVG = gemBPM[Count] / 60;
		Serial.print("gemBPM : ");
		Serial.println(AVG);
	}*/

	ButtonState = digitalRead(Button);

	if (ButtonState == LOW) 
	{
 		SportModus = !SportModus;
	}
	if (SportModus == HIGH)
	{
		Serial.println("Sport Stand : ON");
	}
	else {
		Serial.println("Sport Stand : OFF");
		SendData();
	}

int MinuteBPM[60];
int avgBPM;
avgBPM = MinuteBPM[Second] / 60;

if (BPM >= 0)
{
	MinuteBPM[Second] = BPM;
}

if (Second >= 60)
{
	Serial.print("avgBPM : ");
	Serial.println(avgBPM);
}

}