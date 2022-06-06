import 'package:flutter/material.dart';
import 'package:meet_go_mobile/PasswordInput.dart';
import 'package:meet_go_mobile/TextInputField.dart';
import 'package:meet_go_mobile/pages/Register.dart';
import 'package:meet_go_mobile/pallete.dart';
import 'package:meet_go_mobile/services/APIService.dart';

String? validateInputText(String text) {
  if (text.length == 0) return 'Username is required';
  return null;
}

String? validatePassword(String text) {
  if (text.length == 0) return 'Password is required';
  return null;
}

var result;
GlobalKey<FormState> _formKeyLogin = new GlobalKey<FormState>();

class Login extends StatefulWidget {
  @override
  _LoginState createState() => _LoginState();
}

class _LoginState extends State<Login> {
  @override
  Widget build(BuildContext context) {
    Size size = MediaQuery.of(context).size;
    return Stack(
      children: [
        Container(
          decoration: BoxDecoration(
              image: DecorationImage(
                  image: AssetImage('assets/office3.jpg'),
                  fit: BoxFit.cover,
                  colorFilter:
                      ColorFilter.mode(Colors.black54, BlendMode.darken))),
        ),
        Form(
          key: _formKeyLogin,
          child: Scaffold(
            backgroundColor: Colors.transparent,
            body: Column(
              children: [
                Flexible(
                  child: Center(),
                ),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.end,
                  children: [
                    TextInputField(
                        icon: Icon(Icons.supervised_user_circle),
                        hint: 'Username',
                        inputType: TextInputType.name,
                        inputAction: TextInputAction.next,
                        message: 'Please enter your username'),
                    PasswordInput(
                        icon: Icon(Icons.lock_open),
                        hint: 'Password',
                        inputAction: TextInputAction.next,
                        inputType: TextInputType.name),
                    Container(
                      height: size.height * 0.08,
                      width: size.width * 0.8,
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(16),
                        color: Colors.blueGrey[600],
                      ),
                      child: TextButton(
                        onPressed: () async {
                          if (_formKeyLogin.currentState!.validate()) {
                            await get();
                            if (result != null) {
                              Navigator.of(context)
                                  .pushReplacementNamed('/home');
                            }
                            if (result == null &&
                                APIService.username != "" &&
                                APIService.password != "") _showDialog(context);
                            result = null;
                          }
                        },
                        child: Text(
                          'Login',
                          style: kBodyText.copyWith(
                              fontWeight: FontWeight.bold, color: Colors.white),
                        ),
                      ),
                    ),
                    SizedBox(
                      height: 25,
                    ),
                    SizedBox(
                      height: 25,
                    ),
                  ],
                ),
                GestureDetector(
                  onTap: () => {
                    Navigator.push(
                      context,
                      MaterialPageRoute(builder: (context) => Register()),
                    ),
                    APIService.username = '',
                    APIService.password = ''
                  },
                  child: Container(
                    child: Text(
                      'Register',
                      style: kBodyText,
                    ),
                    decoration: BoxDecoration(
                        border: Border(
                            bottom: BorderSide(width: 1, color: Colors.white))),
                  ),
                ),
                SizedBox(
                  height: 20,
                ),
              ],
            ),
          ),
        )
      ],
    );
  }
}

void _showDialog(BuildContext context) {
  showDialog(
    context: context,
    builder: (BuildContext context) {
      return AlertDialog(
        title: new Text("Error!"),
        content: new Text("Wrong username or password"),
        actions: <Widget>[
          // ignore: deprecated_member_use
          new FlatButton(
            child: new Text("OK"),
            onPressed: () {
              Navigator.of(context).pop();
            },
          ),
        ],
      );
    },
  );
}

Future<void> get() async {
  if (APIService.username != "" && APIService.password != "")
    result = await APIService.Get('Building', null);
}
