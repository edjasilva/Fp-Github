import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'

import "./styles/index.scss";
import App from './App.jsx'
import { createBrowserRouter } from 'react-router-dom';
import Student from './pages/Student.jsx';

const router= createBrowserRouter([
  {path: "/st",
    element:<Student/>,
  }

])

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <App />
    
  </StrictMode>,
)
