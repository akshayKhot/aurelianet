import {Router} from 'aurelia-router';

export class update {
    
    activate(params) {
        this.getPostToUpdate(params.id);
    }
    
    constructor(router) {
        this.post = {};
        this.router = router;
    }

    static inject() {
        return [Router];
    }
    
    getPostToUpdate(id) {
        $.ajax({
            url: `http://localhost:5000/posts/${id}`,
            method: "GET"
        }).done(data => {
            this.post = data;
        });
    }
    
    updatePost(post) {
        $.ajax({
            type: "POST",
            url: `http://localhost:5000/posts/update/${post.id}`,
            data: JSON.stringify({
                title: this.post.title,
                content: this.post.content
            }),
            contentType: "application/json; charset=utf-8",
            success: data => {
                this.router.navigateToRoute('home');
            },
            dataType: 'json'
        });
    }
    
}