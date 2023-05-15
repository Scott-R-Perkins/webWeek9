import React from 'react'
import { Outlet } from 'react-router-dom'

export const home = () => {
  return (
    <div>
        <Outlet></Outlet>
    </div>
  )
}
