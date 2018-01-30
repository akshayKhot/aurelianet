import {Router} from 'aurelia-router';

export class Add {
  
    constructor(router) {
      this.title = "";
      this.post = "";
      this.router = router;
    }

    static inject() {
        return [Router];
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
            success: data => {
                this.router.navigateToRoute('home');
            },
            dataType: 'json'
        });
    }
}