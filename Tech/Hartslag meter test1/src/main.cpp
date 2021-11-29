#include <Arduino.h>
#include <PulseSensorPlayground.h>
#include <WiFiNINA.h>

char SSID[] = "MSI9247";
char PASS[] = "gr3wt2h64";
int status = WL_IDLE_STATUS;

int PulseSensorPurplePin = 0;
int Threshold = 550;
int Signaal;



void setup() 
{
	Serial.begin(9600);

	while (status != WL_CONNECTED)
  	{
   		Serial.println("Connecting to WiFi...");
    	status = WiFi.begin(SSID, PASS);
    	delay(500);
  	}

  	Serial.println("Connected to the WiFi network");
  	Serial.println(WiFi.localIP());
	Serial.println(Signaal);
}

<<<<<<< Updated upstream
void loop() 
{
	Signaal = analogRead(PulseSensorPurplePin);

	if (Signaal > Threshold)
	{
		Serial.println("High");
	}
	else 
	{
		Serial.println("Low");
	}	
		
	Serial.println(Signaal);
	
	Serial.println(WL_CONNECTED);
	delay(300);
=======
  Serial.println(Signal);
  
>>>>>>> Stashed changes
}