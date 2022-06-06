import 'package:flutter/material.dart';
import 'dart:ui';
import 'package:meet_go_mobile/PasswordInput.dart';
import 'package:meet_go_mobile/TextInputField.dart';
import 'package:meet_go_mobile/pallete.dart';
import 'package:meet_go_mobile/services/APIService.dart';

// ignore: must_be_immutable
class Register extends StatelessWidget {
  GlobalKey<FormState> counterKey = new GlobalKey<FormState>();
  var result;

  // ignore: non_constant_identifier_names
  Future<void> RegisterUser() async {
    Map<String, String> body = {
      'email': APIService.email,
      'username': APIService.username,
      'password': APIService.confirmPassword,
    };
    result = await APIService.Register('UserAccount', body);
  }

  @override
  Widget build(BuildContext context) {
    Size size = MediaQuery.of(context).size;
    return Stack(
      children: [
        Container(
          decoration: BoxDecoration(
              image: DecorationImage(
                  image: AssetImage('assets/background.jpg'),
                  fit: BoxFit.cover,
                  colorFilter:
                      ColorFilter.mode(Colors.black54, BlendMode.darken))),
        ),
        Form(
          key: counterKey,
          child: Scaffold(
            backgroundColor: Colors.transparent,
            body: SingleChildScrollView(
              child: Column(
                children: [
                  SizedBox(
                    height: size.width * 0.1,
                  ),
                  Stack(
                    children: [
                      Center(
                        child: ClipOval(
                          child: BackdropFilter(
                            filter: ImageFilter.blur(sigmaX: 3, sigmaY: 3),
                            child: CircleAvatar(
                              radius: size.width * 0.14,
                              backgroundColor: Colors.grey[400]!.withOpacity(
                                0.4,
                              ),
                              child: Icon(
                                Icons.person,
                                color: kWhite,
                                size: size.width * 0.1,
                              ),
                            ),
                          ),
                        ),
                      ),
                      Positioned(
                        top: size.height * 0.08,
                        left: size.width * 0.56,
                        child: Container(
                          height: size.width * 0.1,
                          width: size.width * 0.1,
                          decoration: BoxDecoration(
                            color: kBlue,
                            shape: BoxShape.circle,
                            border: Border.all(color: kWhite, width: 2),
                          ),
                          child: Icon(
                            Icons.arrow_upward,
                            color: kWhite,
                          ),
                        ),
                      )
                    ],
                  ),
                  SizedBox(
                    height: size.width * 0.1,
                  ),
                  Column(
                    children: [
                      TextInputField(
                          icon: Icon(Icons.supervised_user_circle),
                          hint: 'Username',
                          inputType: TextInputType.name,
                          inputAction: TextInputAction.next,
                          message: 'Please enter username'),
                      TextInputField(
                          icon: Icon(Icons.mail),
                          hint: 'Email',
                          inputType: TextInputType.emailAddress,
                          inputAction: TextInputAction.next,
                          message: 'Please enter email'),
                      PasswordInput(
                          icon: Icon(Icons.lock),
                          hint: 'Password',
                          inputAction: TextInputAction.next,
                          inputType: TextInputType.name),
                      PasswordInput(
                          icon: Icon(Icons.lock),
                          hint: 'Confirm Password',
                          inputAction: TextInputAction.done,
                          inputType: TextInputType.name),
                      SizedBox(
                        height: 25,
                      ),
                      Container(
                        height: size.height * 0.08,
                        width: size.width * 0.8,
                        decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(16),
                          color: Colors.lightBlue,
                        ),
                        child: TextButton(
                          onPressed: () async {
                            if (counterKey.currentState!.validate()) {
                              await RegisterUser();
                              if (result != null) {
                                Navigator.of(context)
                                    .pushReplacementNamed('/home');
                              }
                              ScaffoldMessenger.of(context).showSnackBar(
                                const SnackBar(
                                    content: Text('Registration completed!')),
                              );
                            }
                          },
                          child: Text(
                            'Register',
                            style:
                                kBodyText.copyWith(fontWeight: FontWeight.bold),
                          ),
                        ),
                      ),
                      SizedBox(
                        height: 30,
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [
                          Text(
                            'Already have an account?',
                            style: kBodyText,
                          ),
                          SizedBox(
                            width: 5,
                          ),
                          GestureDetector(
                            onTap: () {
                              // Navigator.pushNamed(context, '/login');
                              Navigator.pop(context);
                            },
                            child: Text(
                              'Login',
                              style: kBodyText.copyWith(
                                  color: Colors.lightBlue,
                                  fontWeight: FontWeight.bold),
                            ),
                          ),
                        ],
                      ),
                      SizedBox(
                        height: 20,
                      ),
                    ],
                  )
                ],
              ),
            ),
          ),
        )
      ],
    );
  }
}
