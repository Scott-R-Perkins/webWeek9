import { Box, Heading, Spinner, Text, Button } from '@chakra-ui/react'
import React, { useEffect, useState } from 'react'

export const Home = () => {

    // const [weapons, setWeapons] = useState([])

    // useEffect(() => {
    //     if (weapons.length === 0)
    //         fetch(`${process.env.REACT_APP_BACKEND_URL}/Weapon`)
    //             .then(response => response.json())
    //             .then(data => setWeapons(data));
    // }, [weapons]);

    // console.log(weapons);

    const [weapons, setWeapons] = useState([]);
    const [error, setError] = useState(null);
    
    useEffect(() => {
        if (weapons.length === 0) {
            fetch(`${process.env.REACT_APP_BACKEND_URL}/weapon`)
                .then(response => {
                    if (!response.ok) {
                        throw new Error(`HTTP error! status: ${response.status}`);
                    }
                    return response.json();
                })
                .then(data => setWeapons(data))
                .catch(error => {
                    console.error(error);
                    setError(error);
                });
        }
    }, [weapons]);
    
    if (error) {
        return <div>Error: {error.message}</div>;
    }
    
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
