import {Router} from 'aurelia-router';
import {BlogService} from "./Services/blog-service";

export class Add {
  
    constructor(router, blogService) {
      this.post = {
          title: "",
          content: ""
      };
      this.router = router;
      this.blogService = blogService;
    }

    static inject() {
        return [Router, BlogService];
    }
    
    addPost() {
        this.blogService.addPost(this.post).then(() => {
            this.router.navigateToRoute('home');
        });
    }
}