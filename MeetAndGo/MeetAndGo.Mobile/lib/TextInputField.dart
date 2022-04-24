import 'package:flutter/material.dart';
import 'package:meet_go_mobile/pallete.dart';
import 'package:meet_go_mobile/services/APIService.dart';


class TextInputField extends StatelessWidget {
  const TextInputField({
    required this.icon,
    required this.hint,
    required this.inputType,
    required this.inputAction,
    required this.message,
  }) : super();

  final Icon icon;
  final String hint;
  final TextInputType inputType;
  final TextInputAction inputAction;
  final String message;

  @override
  Widget build(BuildContext context) {
    Size size = MediaQuery.of(context).size;
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 10.0),
      child: Container(
        height: size.height * 0.08,
        width: size.width * 0.8,
        child: Center(
          child: TextFormField(
            onChanged: (txt){
              if (hint == 'Username')
                APIService.username = txt;
              else if (hint == 'Email') APIService.email = txt;
            },
            validator: (value) {
              if (value == null || value.isEmpty) {
                return message;
              }
              return null;
            },
            decoration: InputDecoration(
              border: UnderlineInputBorder(
                borderSide: BorderSide(width: 1, color: Colors.black),
              ),
              errorStyle: TextStyle(color: Colors.white,fontWeight: FontWeight.bold,fontSize: 14),
              prefixIcon: Padding(
                padding: const EdgeInsets.symmetric(horizontal: 20.0),
                child: Icon(
                  icon.icon,
                  size: 28,
                  color: Colors.white,
                ),
              ),
              hintText: hint,
              hintStyle: kBodyText,
            ),
            style: kBodyText,
            keyboardType: inputType,
            textInputAction: inputAction,
          ),
        ),
      ),
    );
  }
}