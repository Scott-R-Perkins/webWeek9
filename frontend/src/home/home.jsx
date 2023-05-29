import { Box, Heading, Spinner, Text, Button, Input, FormControl, FormLabel, Divider, Flex, Grid, Image } from '@chakra-ui/react'
import React, { useEffect, useState } from 'react'

const Home = () => {

    const baseURL = "http://localhost:8000/api"

    const [weapons, setWeapons] = useState([])
    const [armour, setArmours] = useState([])
    const [potions, setPotions] = useState([])
    const [cart, setCart] = useState([]);
    const [searchTerm, setSearchTerm] = useState('');
    const imgurUrl = "https://i.imgur.com/";

    useEffect(() => {
        fetchWeapons();
        fetchArmour();
        fetchPotions();
    }, []);

    const fetchWeapons = async () => {
        fetch(`${baseURL}/Weapon`)
            .then(response => response.json())
            .then(data => setWeapons(data));
    }
    const fetchArmour = async () => {
        fetch(`${baseURL}/Armour`)
            .then(response => response.json())
            .then(data => setArmours(data));
    }
    const fetchPotions = async () => {
        fetch(`${baseURL}/Potion`)
            .then(response => response.json())
            .then(data => setPotions(data));
    }

    const addToCart = (item, category) => {
        let itemId;
        switch (category) {
            case 'weapon':
                itemId = item.weaponId;
                break;
            case 'armour':
                itemId = item.armourId;
                break;
            case 'potion':
                itemId = item.potionId;
                break;
            default:
                itemId = item.id;
        }
        const existingItem = cart.find((cartItem) => cartItem.id === itemId);
        if (existingItem) {
            const updatedCart = cart.map((cartItem) =>
                cartItem.id === itemId ? { ...cartItem, count: cartItem.count + 1 } : cartItem
            );
            setCart(updatedCart);
        } else {
            setCart([...cart, { ...item, count: 1, id: itemId }]);
        }
    };


    const renderItem = (item, category) => (
        <Box p={2} borderWidth={1} borderRadius="lg" maxW="sm">
            {/* Need to save an img url as part of the items on the backend, then call them as item.imgUrl or 
                something instead of this placeholder*/}
            <Image borderRadius="md" src={imgurUrl + item.imgURL + ".png"} /> 
            <Text fontSize='md'>{item.name}</Text>
            {category === 'weapon' &&
                <>
                    <Text fontSize='sm'>Attack Value: {item.attackValue}</Text>
                    <Text fontSize='sm'>Attack Speed: {item.attackSpeed}</Text>
                    <Text fontSize='sm'>DPS: {item.dps}</Text>
                    <Text fontSize='sm'>Ability damage modifier: {item.abilityDamageModifier}</Text>
                </>
            }
            {category === 'armour' &&
                <>
                    <Text fontSize='sm'>Physical Defence: {item.physicalDefenceValue}</Text>
                    <Text fontSize='sm'>Magical Defence: {item.magicalDefenceValue}</Text>
                </>
            }
            {category === 'potion' &&
                <>
                    <Text fontSize='sm'>Effect: {item.potionDescription}</Text>
                    <Text fontSize='sm'>Potency: {item.potionPotencyValue}</Text>
                </>
            }
            <Text fontSize='sm'>Price: {item.price} gold</Text>
            <Text fontSize='sm'>{item.flavourText}</Text>
            <Button size="sm" onClick={() => addToCart(item, category)}>Add to Cart</Button>
        </Box>
    );

    if (weapons.length === 0 || armour.length === 0 || potions.length === 0) return <Spinner />;

    return (
        <Flex>
            <Box flex="3">
                <FormControl>
                    <FormLabel>Search:</FormLabel>
                    <Input onChange={e => setSearchTerm(e.target.value)} type={'text'} />
                </FormControl>

                <Divider mt={4} mb={4} />

                <Heading p={2}>Weapons</Heading>
                <Grid templateColumns="repeat(3, 1fr)" gap={6}>
                    {weapons.filter(item => item.name.toLowerCase().includes(searchTerm.toLowerCase())).map(weapon => renderItem(weapon, 'weapon'))}
                </Grid>

                <Heading p={2}>Armour</Heading>
                <Grid templateColumns="repeat(3, 1fr)" gap={6}>
                    {armour.filter(item => item.name.toLowerCase().includes(searchTerm.toLowerCase())).map(armour => renderItem(armour, 'armour'))}
                </Grid>

                <Heading p={2}>Potions</Heading>
                <Grid templateColumns="repeat(3, 1fr)" gap={6}>
                    {potions.filter(item => item.name.toLowerCase().includes(searchTerm.toLowerCase())).map(potion => renderItem(potion, 'potion'))}
                </Grid>
            </Box>

            <Divider orientation="vertical" />

            <Box flex="1" ml={4}>
                <Heading p={2}>Cart</Heading>
                {cart.map((item) => (
                    <Box key={item.id}>
                        <Text>{item.name} x {item.count}</Text>
                        <Text>Total: {item.count * item.price} gold</Text>
                    </Box>
                ))}
                <Text mt={4}>Total Cart Value: {cart.reduce((acc, item) => acc + (item.count * item.price), 0)} gold</Text>
            </Box>

        </Flex>
    )
}
export default Home;





//     return (
//         <Box>
//             <Heading p={4}>Weapons</Heading>
//             <Box>
//                 {weapons.map(weapon => (
//                     <Box p={4} borderWidth={1} borderRadius="lg">
//                         <Text key={weapon.weaponId} color={'purple.600'} fontSize='2xl'>{weapon.name}<br></br></Text>
//                         <Text color={'red.600'}>Attack Value: {weapon.attackValue}<br></br></Text>
//                         <Text color={'red.600'}> Attack Speed: {weapon.attackSpeed}<br></br></Text>
//                         <Text color={'blue.600'}> DPS: {weapon.dps}<br></br></Text>
//                         <Text color={'blue.600'}> Ability damage modifier {weapon.abilityDamageModifier}<br></br></Text>
//                         <Text color={'goldenrod'}> Price: {weapon.price} gold<br></br></Text>
//                         <Text color={'orange.400'}> {weapon.flavourText}<br></br> <br></br> </Text>
//                     </Box>
//                 ))}
//             </Box>
//             <Heading p={4}>Armour</Heading>
//             <Box>
//                 {armour.map(armour => (
//                     <Box p={4} borderWidth={1} borderRadius="lg">
//                         <Text key={armour.armourId} color={'purple.600'} fontSize='2xl'>{armour.name}<br></br></Text>
//                         <Text color={'red.600'}>Physical Defence: {armour.physicalDefenceValue} <br></br></Text>
//                         <Text color={'blue.600'}>Magical Defence: {armour.magicalDefenceValue} <br></br></Text>
//                         <Text color={'goldenrod'}>Price: {armour.price} gold<br></br></Text>
//                         <Text color={'orange.400'}>{armour.flavourText}<br></br><br></br></Text>
//                     </Box>
//                 ))}
//             </Box>
//             <Heading p={4}>Potions</Heading>
//             <Box>
//                 {potions.map(potions => (
//                     <Box p={4} borderWidth={1} borderRadius="lg">
//                         <Text key={potions.potionId} color={'purple.600'} fontSize='2xl'>{potions.name}<br></br></Text>
//                         <Text color={'orange.400'}>Effect: {potions.potionDescription}<br></br></Text>
//                         <Text color={'red.600'}>Potency: {potions.potionPotencyValue}<br></br></Text>
//                         <Text color={'goldenrod'}>Price: {potions.price} gold<br></br><br></br></Text>
//                     </Box>
//                 ))}
//             </Box>
//         </Box>
//     )
// }
// export default Home;