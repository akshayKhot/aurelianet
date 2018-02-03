
export class BlogService {

    // Create 
    addPost(post) {
        return $.ajax({
            method: "POST",
            url: "http://localhost:5000/posts",
            data: JSON.stringify(post),
            contentType: "application/json; charset=utf-8",
            success: () => {},
            dataType: 'json'
        });
    }

    addAuthor(author) {
        return $.ajax({
            method: "POST",
            url: "http://localhost:5000/author",
            data: JSON.stringify(author),
            contentType: "application/json; charset=utf-8",
            success: () => {},
            dataType: 'json'
        });
    }
    
    // Read
    getPosts() {
        return $.ajax({
            url: "http://localhost:5000/posts",
            method: "GET"
        }).done(data => {
            return data;
        });
    }
    
    getAuthors() {
        return $.ajax({
            url: "http://localhost:5000/authors",
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

    getAuthor(id) {
        return $.ajax({
            url: `http://localhost:5000/authors/${id}`,
            method: "GET"
        }).done(data => {
            return data;
        });
    }

    getAllPostsForAuthor(id) {
        return $.ajax({
            url: `http://localhost:5000/posts/auth/${id}`,
            method: "GET"
        }).done(data => {
            return data;
        });
    }

    // Update
    updatePost(post) {
        return $.ajax({
            method: "PUT",
            url: `http://localhost:5000/posts`,
            data: JSON.stringify(post),
            contentType: "application/json; charset=utf-8",
            dataType: 'text'
        });
    }

    updateAuthor(author) {
        return $.ajax({
            method: "PUT",
            url: `http://localhost:5000/authors`,
            data: JSON.stringify(author),
            contentType: "application/json; charset=utf-8",
            dataType: 'json'
        });
    }
    
    // Delete
    deletePost(id) {
        return $.ajax({
            type: "DELETE",
            url: "http://localhost:5000/posts/" + id,
            success: () => {},
            dataType: 'text'
        });
    }
    
    deleteAuthor(id) {
        return $.ajax({
            type: "DELETE",
            url: "http://localhost:5000/authors/delete/" + id,
            success: () => {},
            dataType: 'text'
        });
    }

}