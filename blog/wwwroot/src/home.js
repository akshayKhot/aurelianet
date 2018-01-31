import {Router} from 'aurelia-router';
import {BlogService} from "./Services/blog-service";

export class home {
    
    constructor(router, blogService) {
        this.router = router;
        this.blogService = blogService;
    }
    
    activate() {
        this.getPosts();
    }
    
    static inject() {
        return [Router, BlogService];
    }
    
    deletePost(post) {
        this.blogService.deletePost(post).then(() => {
            this.getPosts();
        });
    }
    
    getPosts() {
        this.blogService.getPosts().then(posts => {
            this.posts = posts;
        });
    }
    
    updatePost(post) {
        this.router.navigateToRoute("update", { id: post.id });
    }
}