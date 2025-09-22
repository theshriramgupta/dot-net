import { useState } from "react";
import "./App.css";

const posts = [
  {
    name: "Jerma",
    username: "@Jerma985",
    avatar: "https://i.pravatar.cc/100?img=12",
    content:
      "I spent the last 20 min going line by line translating this old note I had on my iPhone...",
    comments: 216,
    likes: 52700,
    date: "August 6th, 2022 • 9:13 AM",
  },
  {
    name: "Alice",
    username: "@alice123",
    avatar: "https://i.pravatar.cc/100?img=45",
    content: "Just finished my React project 🚀 #100DaysOfCode",
    comments: 98,
    likes: 1340,
    date: "August 7th, 2022 • 2:45 PM",
  },
  {
    name: "Mark",
    username: "@mark_dev",
    avatar: "https://i.pravatar.cc/100?img=23",
    content: "Working on a new AI project 🤖✨ Stay tuned!",
    comments: 150,
    likes: 8400,
    date: "August 8th, 2022 • 6:12 PM",
  },
];

function App() {
  const [index, setIndex] = useState(0);

  const nextPost = () => {
    setIndex((prev) => (prev + 1) % posts.length);
  };

  const prevPost = () => {
    setIndex((prev) => (prev - 1 + posts.length) % posts.length);
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
          <span>💬 {post.comments}</span>
          <span>❤️ {post.likes.toLocaleString()}</span>
        </div>

        <small>{post.date}</small>
      </div>

      <div className="arrow" onClick={nextPost}>
        ➡
      </div>
    </div>
  );
}

export default App;
