import 'package:flutter/material.dart';
import 'package:meet_go_mobile/pages/Building.dart';
import 'package:meet_go_mobile/pages/Login.dart';
import 'package:meet_go_mobile/pages/Loading.dart';
import 'package:meet_go_mobile/pages/Office.dart';
import 'package:meet_go_mobile/pages/Home.dart';
import 'package:meet_go_mobile/pages/RentedBuilding.dart';
import 'package:meet_go_mobile/pages/RentedOffice.dart';

void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  runApp(MyApp());
}

class MyApp extends StatefulWidget {
  @override
  _MyAppState createState() => _MyAppState();
}

class _MyAppState extends State<MyApp> {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Login(),
      routes: {
        '/login': (context) => Login(),
        '/home': (context) => Home(),
        '/loading': (context) => Loading(),
        '/office': (context) => Office(),
        '/building': (context) => Building(),
        '/rentedoffice': (context) => RentedOffice(),
        '/rentedbuilding': (context) => RentedBuilding(),
      },
    );
  }
}
