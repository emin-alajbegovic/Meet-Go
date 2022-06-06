class mdlUserAccount {
  final int userId;
  final String username;

  mdlUserAccount({
    required this.userId,
    required this.username,
  });

  factory mdlUserAccount.fromJson(Map<String, dynamic> json) {
    return mdlUserAccount(
      userId: json["userId"],
      username: json["username"],
    );
  }
}
