import React from "react";
import { TweetCardProps } from "./TweetCard.types";

const TweetCard: React.FC<TweetCardProps> = ({
  avatarUrl,
  username,
  handle,
  content,
  replies,
  likes,
  date,
  time,
}) => {
  return (
    <div className="w-full max-w-xl rounded-2xl border border-gray-300 bg-white shadow-md transition hover:shadow-lg">
      <div className="p-4">
        
        {/* Header */}
        <div className="flex items-center justify-between">
          <div className="flex items-center space-x-3">
            <img
              src={avatarUrl}
              alt={username}
              className="h-12 w-12 rounded-full border border-gray-200"
            />
            <div>
              <p className="font-semibold text-gray-900">{username}</p>
              <p className="text-sm text-gray-500">{handle}</p>
            </div>
          </div>
          <span className="text-lg font-bold text-gray-500">X</span>
        </div>

        {/* Content */}
        <p className="mt-3 text-gray-800 text-[15px] leading-relaxed whitespace-pre-line">
          {content}
        </p>

        {/* Footer */}
        <div className="mt-4 flex items-center justify-between text-gray-500 text-sm">
          <div className="flex space-x-6">
            <p className="flex items-center space-x-1">
              <span>💬</span> <span>{replies}</span>
            </p>
            <p className="flex items-center space-x-1">
              <span>❤️</span> <span>{likes.toLocaleString()}</span>
            </p>
          </div>
          <p>
            {date} • {time}
          </p>
        </div>
      </div>
    </div>
  );
};

export default TweetCard;
