import React from 'react';
import ChatMessage from './ChatMessage';

const ChatWindow = (props) => {
    const chat = props.chat
    .map(m => <ChatMessage key={Date.now()*Math.random()} user={m.user} message={m.message} />);

    return (
        <div>{chat}</div>
    )
};

export default ChatWindow;