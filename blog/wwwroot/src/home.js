import {Router} from 'aurelia-router';

export class home {
    
    constructor(router) {
        this.router = router;
    }
    
    activate() {
        this.getPosts();
    }
    
    static inject() {
        return [Router];
    }
    
    deletePost(post) {
        $.ajax({
            type: "POST",
            url: "http://localhost:5000/posts/delete/" + post.id,
            success: data => {
                console.log(data);
                if (data === "success") {
                    this.getPosts();
                }
            },
            dataType: 'text'
        });
    }
    
    getPosts() {
        $.ajax({
            url: "http://localhost:5000/posts",
            method: "GET"
        }).done(data => {
            this.posts = data;});
    }
    
    updatePost(post) {
        this.router.navigateToRoute("update", { id: post.id });
    }
}