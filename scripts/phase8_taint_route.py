from flask import request


@app.route("/user")
def get_user():
    user_id = request.args.get("id")
    cursor.execute(f"SELECT * FROM users WHERE id={user_id}")
    return "ok"
