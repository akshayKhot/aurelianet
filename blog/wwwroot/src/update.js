import {Router} from 'aurelia-router';
import {BlogService} from "./Services/blog-service";

export class update {
    
    activate(params) {
        this.getPostToUpdate(params.id);
    }
    
    constructor(router, blogService) {
        this.router = router;
        this.blogService = blogService;
    }

    static inject() {
        return [Router, BlogService];
    }
    
    getPostToUpdate(id) {
        this.blogService.getPost(id).then(post => {
            this.post = post;
        });
    }
    
    updatePost() {
        this.blogService.updatePost(this.post).then(() => {
            this.router.navigateToRoute('home');
        });
    }
    
}