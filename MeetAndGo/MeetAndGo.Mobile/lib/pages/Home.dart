import 'package:flutter/material.dart';
import 'package:meet_go_mobile/services/APIService.dart';


class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Side menu'),
      ),
      drawer: Drawer(
        child: ListView(
          padding: EdgeInsets.zero,
          children: [
            DrawerHeader(
              child: Text(
                  ''
                // 'Side menu',
                // style: TextStyle(color: Colors.black45, fontSize: 25),
              ),
              decoration: BoxDecoration(
                  image: DecorationImage(
                      fit: BoxFit.fitHeight,
                      image: AssetImage('assets/heartPaw.png'))),
            ),
            ListTile(
                leading: Icon(Icons.pets),
                title: Text('Životinje'),
                onTap: () {
                  Navigator.of(context).popAndPushNamed('/zivotinje');
                }),
            ListTile(
              leading: Icon(Icons.verified_user),
              title: Text('Profil'),
              onTap: () => {
                Navigator.of(context).popAndPushNamed('/profil')
              },
            ),
            ListTile(
                leading: Icon(Icons.favorite),
                title: Text('Akcije'),
                onTap: () {
                  Navigator.of(context).popAndPushNamed('/akcije');
                }),
            ListTile(
                leading: Icon(Icons.attach_money),
                title: Text('Moje Donacije'),
                onTap: () {
                  Navigator.of(context).popAndPushNamed('/mojedonacije');
                }),
            ListTile(
                leading: Icon(Icons.volunteer_activism),
                title: Text('Prijavi životinju'),
                onTap: () {
                  Navigator.of(context).popAndPushNamed('/prijava');
                }),
            ListTile(
                leading: Icon(Icons.exit_to_app),
                title: Text('Logout'),
                onTap: () => {
                  Navigator.of(context).popAndPushNamed('/login'),
                  APIService.username = "",
                  APIService.password = "",
                }
            ),
          ],
        ),
      ),
    );
  }
}