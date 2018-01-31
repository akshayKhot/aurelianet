
export class BlogService {

    addPost(post) {
        return $.ajax({
            type: "POST",
            url: "http://localhost:5000/posts/add",
            data: JSON.stringify({
                title: post.title,
                content: post.content
            }),
            contentType: "application/json; charset=utf-8",
            success: () => {},
            dataType: 'json'
        });
    }
    
    getPosts() {
        return $.ajax({
            url: "http://localhost:5000/posts",
            method: "GET"
        }).done(data => {
            return data;
        });
    }
    
    getPost(id) {
        return $.ajax({
            url: `http://localhost:5000/posts/${id}`,
            method: "GET"
        }).done(data => {
            return data;
        });
    }

    updatePost(post) {
        return $.ajax({
            type: "POST",
            url: `http://localhost:5000/posts/update/${post.id}`,
            data: JSON.stringify({
                title: post.title,
                content: post.content
            }),
            contentType: "application/json; charset=utf-8",
            success: data => {},
            dataType: 'json'
        });
    }
    
    deletePost(post) {
        return $.ajax({
            type: "POST",
            url: "http://localhost:5000/posts/delete/" + post.id,
            success: () => {},
            dataType: 'text'
        });
    }

}