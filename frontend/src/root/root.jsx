import React from 'react'
import { Outlet } from 'react-router-dom'

export const Root = () => {
  return (
    <div>
        <Outlet></Outlet>
    </div>
  )
}
export default Root;
