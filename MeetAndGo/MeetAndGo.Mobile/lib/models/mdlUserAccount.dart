import 'package:flutter/material.dart';

class mdlUserAccount {
  final int userAccountId;
  final String username;

  mdlUserAccount({
    required this.userAccountId,
    required this.username,
  });

  factory mdlUserAccount.fromJson(Map<String, dynamic> json) {
    return mdlUserAccount(
      userAccountId: json["userAccountId"],
      username: json["username"],
    );
  }
}
