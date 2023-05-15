import { Box, Heading, Spinner, Text } from '@chakra-ui/react'
import React, { useEffect, useState } from 'react'

export const home = () => {

    const [foods, setFoods] = useState([])

    useEffect(() => {
        if (foods.length === 0) 
            fetch(`$(process.end.REACT_APP_BACKEND_URL)/Foods`)
                .then(response => response.json())
                .then(data => setFoods(data));
    }, [foods]);

    console.log(foods);

    if(foods.length === 0) return <Spinner/>;

    return (
        <Box>
            <Heading>Home</Heading>
            <Box>
                (foods.map(food => (<Text key=(food.id)>food.name</Text>)))
            </Box>
        </Box>
    )
}
