import React from 'react'
import { Outlet } from 'react-router-dom'

export const root = () => {
  return (
    <div>
        <Outlet></Outlet>
    </div>
  )
}
