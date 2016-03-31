CONFIGURATION=Release

XCODEBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
TARGET=SWRevealViewController
PROJECT=Pods.xcodeproj
STATIC_LIB=libSWRevealViewController.a

all : clean ../binding/SWRevealViewController/SWRevealViewController/bin/$(CONFIGURATION)/Xamarin.SWRevealViewController.dll

Pods/Pods.xcodeproj/project.pbxproj :
	sharpie pod init -f ios $(TARGET)

$(CONFIGURATION)-iphoneos/$(STATIC_LIB) : Pods/Pods.xcodeproj/project.pbxproj
	cd Pods && $(XCODEBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -configuration $(CONFIGURATION) clean build
	-mv build/$(CONFIGURATION)-iphoneos ./

$(CONFIGURATION)-iphonesimulator/$(STATIC_LIB) : $(CONFIGURATION)-iphoneos/$(STATIC_LIB)
	cd Pods && $(XCODEBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration $(CONFIGURATION) clean build
	-mv build/$(CONFIGURATION)-iphonesimulator ./

$(CONFIGURATION)-iphoneuniversal/$(STATIC_LIB) : $(CONFIGURATION)-iphonesimulator/$(STATIC_LIB)
	mkdir -p $(CONFIGURATION)-iphoneuniversal
	cp -r $(CONFIGURATION)-iphoneos/. $(CONFIGURATION)-iphoneuniversal/
	lipo $(CONFIGURATION)-iphonesimulator/$(STATIC_LIB) $(CONFIGURATION)-iphoneos/$(STATIC_LIB) -create -output $(CONFIGURATION)-iphoneuniversal/$(STATIC_LIB)

../binding/SWRevealViewController/SWRevealViewController/bin/$(CONFIGURATION)/Xamarin.SWRevealViewController.dll : $(CONFIGURATION)-iphoneuniversal/$(STATIC_LIB)
	cd ../binding/SWRevealViewController/SWRevealViewController && XBuild /p:Configuration=$(CONFIGURATION)
	#cd ../binding/SWRevealViewController/SWRevealViewController && nuget pack SWRevealViewController.nuspec

clean :
	rm -rf SWRevealViewController
	rm -rf $(CONFIGURATION)-iphoneos
	rm -rf $(CONFIGURATION)-iphonesimulator
	rm -rf $(CONFIGURATION)-iphoneuniversal