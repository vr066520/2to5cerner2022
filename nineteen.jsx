import React, { useState } from "react";
//cerner_2^5_2022
export default function App() {
  const [firstNum, setFirstNum] = useState(24);
  const [secondNum, setSecondNum] = useState(24);
  const [firstStr, setFirstStr] = useState("24");
  const [secondStr, setSecondStr] = useState("24");
  return (
    <div className="App">
      <h1>{`adding two numbers example`}</h1>
      <p>{firstNum + secondNum}</p>
      <h1>{`adding two string numbers example`}</h1>
      <p>{parseInt(firstStr) + parseInt(secondStr)}</p>
    </div>
  );
}