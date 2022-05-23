import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:meet_go_mobile/pages/Building.dart';
import 'package:meet_go_mobile/pages/Login.dart';
import 'package:meet_go_mobile/pages/Loading.dart';
import 'package:meet_go_mobile/pages/Office.dart';
import 'package:meet_go_mobile/pages/Home.dart';
import 'package:meet_go_mobile/pages/OfficeRent.dart';
import 'package:meet_go_mobile/pages/RentedBuilding.dart';
import 'package:meet_go_mobile/pages/RentedOffice.dart';

void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  Stripe.publishableKey =
      'pk_test_51KxzekCJzjFO4SESz11VLHQh49MqV5yruUuYndpkfRcXzvpbxMaKAMLEniDdYjpRi4xULN68Jc9qV2bVKRZwUv8W00bPhU3tYe';
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
        '/officerent': (context) => OfficeRent(),
        '/building': (context) => Building(),
        '/rentedoffice': (context) => RentedOffice(),
        '/rentedbuilding': (context) => RentedBuilding(),
      },
    );
  }
}
