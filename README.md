# MAUI
 Mobile.NET

--- **. [마우이, MAUI]

--- 01. 설명
	> .NET MAUI (Multi-platform App UI) 는
	  하나의 C# 코드베이스로 iOS, Android, macOS, Windows 앱을 동시에 개발할 수 있는 크로스 플랫폼 UI 프레임워크

	> MAUI 는 Xamarin.Forms 의 차세대 버전이며, .NET 6 이상에서 정식 출시 되었음

--- 02. 개발 환경
	> 기본 필요 사항
	  --- ● OS 
		> Windows 10/11 (Android + Windows 개발) 또는 macOS(iOS + Android 개발)
	  --- ● .NET SDK
		> .NET 8 SDK 이상(최신 권장)
	  --- ● IDE
		> Visual Studio 2022 이상(또는 Visual Studio for Mac)
	  --- ● Visual Studio 워크로드
		> ".NET MAUI 개발" + "Android/iOS 개발 도구" 선택 설치

	> 플랫폼 별 추가 요구사항
	  --- ● Android
		> Visual Studio 설치 시 Android SDK 포함
	  --- ● iOS
		> Mac 필수 + Xcode 필요
		> iOS 빌드/배포는 Apple 개발자 계정 필요
	  --- ● Windows
		> UWP/WinUI 용 Windows SDK 포함됨
	  --- ● macOS
		> macOS 13 이상 + Xcode 설치 + .NET SDK + VS for Mac

	> Apple 개발자 계정(iOS 배포용)
	  - Apple Developer Program 가입 필요 (연 99$)
	  - iOS 앱을 빌드/테스트/배포하려면 필수
	  - Xcode 에서 생성한 인증서 및 프로비저닝 프로파일 필요

	> Google Play 개발자 계정(Android 배포용)
	  - Google Play Console 가입(1회 25$)
	  - 앱 배포 시 APK 또는 AAB 파일을 업로드하게 됨

	> 필요한 도구 정리
	  --- ● Visual Studio 2022 이상
		> MAUI 앱 개발 지원
	  --- ● .NET 8 SDK 이상
		> 앱 실행 및 빌드
	  --- ● Android Emulator / Device
		> Android 앱 테스트용
	  --- ● Mac + Xcode
		> iOS 앱 개발 및 테스트
	  --- ● Apple 개발자 계정
		> iOS 앱 서명 및 배포
	  --- ● Google Play Console 계정
		> Android 앱 배포

--- 03. MAUI 프로젝트 기본 구조
	======================
	MyApp/
	|
	|--Playforms/
	|	|
	|	|-- Android/
	|	|
	|	|-- iOS/
	|	|
	|	|-- Windows/
	|	|
	|	|-- MacCatalyst/
	|	
	|
	|--Resources/		← 이미지, 글꼴, 스타일 등
	|
	|--App.xaml		← 전체 앱의 리소스 정의
	|
	|--MainPage.xaml	← 첫 시작 화면
	|
	|--App.xaml.cs		← 앱 시작 로직
	|
	|--MainPage.xaml.cs	← MainPage 로직
	|
	|--MyApp.csproj		← 프로젝트 파일
	======================

--- 04. 배포 준비 요약
	=======================================================================================
	플랫폼		개발 시 필요한 것		배포 시 필요한 것
	---------------------------------------------------------------------------------------
	Android		Visual Studio + Android SDK	Google Play 개발자 계정, APK/AAB

	iOS		Mac + Xcode + VisualStudio	Apple 개발자 계정, 프로비저닝 프로파일

	Windows		Windows 10/11 + VS		MS 스토어 (선택적)
	
	macOS		MacCatalyst + Xcode		Notarization 필요 (App Store는 옵션)
	=======================================================================================

--- 05. 개발부터 배포까지 흐름 요약
	> Visual Studio 에서 .NET MAUI App 프로젝트 생성
	> Android/iOS 에뮬레이터 또는 실기기에서 테스트
	> 배포 준비
	  --- ● Android
		> APK 또는 AAB 빌드 (release)
	  --- ● iOS
		> Apple 인증서 설정 후 IPA 빌드
	> 앱 스토어 등록(Google Play / Apple App Store)
	

--- 05. 결론(체크리스트)
	> Visual Studio 2022 이상 + MAUI 워크로드
	> .NET 8 SDK
	> Android Emulator 또는 Android 기기
	> (iOS용) macOS + Xcode + Apple 개발자 계정
	> (배포용) Google Play 및 Apple 개발자 계정