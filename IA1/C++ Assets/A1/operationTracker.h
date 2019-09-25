#pragma once
#include "PluginSettings.h"
#include <iostream>
#include <fstream>
using namespace std;

class PLUGIN_API operationTracker
{
public:
	//Object Position Memory
	float savedPosiX[21] = { 0 };
	float savedPosiY[21] = { 0 };
	float savedPosiZ[21] = { 0 };

	//Object Type Memory
	int savedType[21] = { 0 };

	ofstream objectPosiFileOut;
	ifstream objectPosiFileIn;

	//Pass out and in positions / type
	void savePosi(float, float, float, int);
	void saveType(int, int);
	float getPosiX(int);
	float getPosiY(int);
	float getPosiZ(int);
	int getType(int);

	//FILE Garbo
	float filePosiX = 0;
	float filePosiY = 0;
	float filePosiZ = 0;
	void savePosiToText(float, float, float);
	void getPosiFromText();

	float getPosiFromTextX();
	float getPosiFromTextY();
	float getPosiFromTextZ();
};