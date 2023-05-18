import { Box, Heading, Spinner, Text, Button } from '@chakra-ui/react'
import React, { useEffect, useState } from 'react'

export const Home = () => {

    const [weapons, setWeapons] = useState([])

    useEffect(() => {
        if (weapons.length === 0)
            fetch(`${process.env.REACT_APP_BACKEND_URL}/Weapons`)
                .then(response => response.json())
                .then(data => setWeapons(data));
    }, [weapons]);

    console.log(weapons);

    if (weapons.length === 0) return <Spinner />;

    return (
        <Box>
            <Heading>Home</Heading>
            <Box>
                {weapons.map(weapon => (
                    <Text key={weapon.id}>{weapon.name}</Text>
                ))}
            </Box>
        </Box>
    )
}
export default Home;
