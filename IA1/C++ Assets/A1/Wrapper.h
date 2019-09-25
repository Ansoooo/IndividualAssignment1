#pragma once
#include "PluginSettings.h"
#include "SimpleClass.h"
#include "operationTracker.h"

#ifdef __cplusplus
extern "C"
{
#endif
	// Put your functions here
	PLUGIN_API int SimpleFunction();

	// operationTracker Functions
	PLUGIN_API void savePosi(float, float, float, int);
	PLUGIN_API void saveType(int, int);
	PLUGIN_API float getPosiX(int);
	PLUGIN_API float getPosiY(int);
	PLUGIN_API float getPosiZ(int);
	PLUGIN_API int getType(int);

	PLUGIN_API void savePosiToText(float, float, float);
	PLUGIN_API void getPosiFromText();
	PLUGIN_API float getPosiFromTextX();
	PLUGIN_API float getPosiFromTextY();
	PLUGIN_API float getPosiFromTextZ();

#ifdef __cplusplus
}
#endif