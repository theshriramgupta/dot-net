import { useState } from "react";
import "./App.css";

const initialPosts = [
  {
    id: 1,
    name: "Jerma",
    username: "@Jerma985",
    avatar: "https://i.pravatar.cc/100?img=12",
    content:
      "I spent the last 20 min going line by line translating this old note I had on my iPhone...",
    comments: ["So true!", "Haha, relatable 😂"],
    likes: 52700,
    date: "August 6th, 2022 • 9:13 AM",
    liked: false,
  },
  {
    id: 2,
    name: "Alice",
    username: "@alice123",
    avatar: "https://i.pravatar.cc/100?img=45",
    content: "Just finished my React project 🚀 #100DaysOfCode",
    comments: ["Congrats!", "Keep it up! 💪"],
    likes: 1340,
    date: "August 7th, 2022 • 2:45 PM",
    liked: false,
  },
  {
    id: 3,
    name: "Mark",
    username: "@mark_dev",
    avatar: "https://i.pravatar.cc/100?img=23",
    content: "Working on a new AI project 🤖✨ Stay tuned!",
    comments: ["Excited for this!", "When is the launch?"],
    likes: 8400,
    date: "August 8th, 2022 • 6:12 PM",
    liked: false,
  },
];

function App() {
  const [posts, setPosts] = useState(initialPosts);
  const [index, setIndex] = useState(0);
  const [newComment, setNewComment] = useState("");
  const [showComments, setShowComments] = useState(false); // NEW state

  const nextPost = () => {
    setIndex((prev) => (prev + 1) % posts.length);
    setShowComments(false); // hide comments when moving
  };

  const prevPost = () => {
    setIndex((prev) => (prev - 1 + posts.length) % posts.length);
    setShowComments(false); // hide comments when moving
  };

  const toggleLike = (id) => {
    setPosts((prev) =>
      prev.map((p) =>
        p.id === id
          ? { ...p, liked: !p.liked, likes: p.liked ? p.likes - 1 : p.likes + 1 }
          : p
      )
    );
  };

  const addComment = (id) => {
    if (newComment.trim() === "") return;
    setPosts((prev) =>
      prev.map((p) =>
        p.id === id ? { ...p, comments: [...p.comments, newComment] } : p
      )
    );
    setNewComment("");
  };

  const post = posts[index];

  return (
    <div className="card-container">
      <div className="arrow" onClick={prevPost}>
        ⬅
      </div>

      <div className="card">
        <div className="header">
          <img src={post.avatar} alt="avatar" />
          <div className="info">
            <span>{post.name}</span>
            <small>{post.username}</small>
          </div>
        </div>

        <div className="content">{post.content}</div>

        <div className="stats">
          <span
            onClick={() => toggleLike(post.id)}
            style={{ cursor: "pointer" }}
          >
            {post.liked ? "❤️" : "🤍"} {/* post.likes.toLocaleString() */}
          </span>
          <span
            style={{ cursor: "pointer" }}
            onClick={() => setShowComments((prev) => !prev)} // toggle comments
          >
          💬{/* post.comments.length */}
          </span>
        </div>

        <small>{post.date}</small>

        {/* Show comments only if toggled */}
        {showComments && (
          <div className="comments">
            <h4>Comments:</h4>
            {post.comments.map((c, i) => (
              <p key={i}>💬 {c} </p>
            ))}
            <div className="comment-box">
              <input
                type="text"
                placeholder="Write a comment..."
                value={newComment}
                onChange={(e) => setNewComment(e.target.value)}
              />
              <button onClick={() => addComment(post.id)}>Post</button>
            </div>
          </div>
        )}
      </div>

      <div className="arrow" onClick={nextPost}>
        ➡
      </div>
    </div>
  );
}

export default App;
