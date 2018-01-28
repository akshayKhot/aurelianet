export class Add {
  
    constructor() {
      this.title = "";
      this.post = "";
    }
    
    addPost() {
        $.ajax({
            type: "POST",
            url: "http://localhost:5000/posts/add",
            data: JSON.stringify({
                title: this.title,
                content: this.post
            }),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log(data);
            },
            dataType: 'json'
        });
    }
}