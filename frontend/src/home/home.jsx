import { Box, Heading, Spinner, Text, Button } from '@chakra-ui/react'
import React, { useEffect, useState } from 'react'

export const Home = () => {

    const baseURL = "http://localhost:8000/api"

    const [weapons, setWeapons] = useState([])
    const [armour, setArmours] = useState([])
    const [potions, setPotions] = useState([])

    useEffect(() => {
        fetchWeapons();
        fetchArmour();
        fetchPotions();
    }, [weapons], [armour], [potions]);

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

    if (weapons.length === 0) return <Spinner />;

    return (
        <Box>
            <Heading p={4}>Weapons</Heading>
            <Box>
                {weapons.map(weapon => (
                    <Box p={4} borderWidth={1} borderRadius="lg">
                        <Text key={weapon.weaponId} color={'purple.600'} fontSize='2xl'>{weapon.name}<br></br></Text>
                        <Text color={'red.600'}>Attack Value: {weapon.attackValue}<br></br></Text>
                        <Text color={'red.600'}> Attack Speed: {weapon.attackSpeed}<br></br></Text>
                        <Text color={'blue.600'}> DPS: {weapon.dps}<br></br></Text>
                        <Text color={'blue.600'}> Ability damage modifier {weapon.abilityDamageModifier}<br></br></Text>
                        <Text color={'goldenrod'}> Price: {weapon.price} gold<br></br></Text>
                        <Text color={'orange.400'}> {weapon.flavourText}<br></br> <br></br> </Text>
                    </Box>
                ))}
            </Box>
            <Heading p={4}>Armour</Heading>
            <Box>
                {armour.map(armour => (
                    <Box p={4} borderWidth={1} borderRadius="lg">
                        <Text key={armour.armourId} color={'purple.600'} fontSize='2xl'>{armour.name}<br></br></Text>
                        <Text color={'red.600'}>Physical Defence: {armour.physicalDefenceValue} <br></br></Text>
                        <Text color={'blue.600'}>Magical Defence: {armour.magicalDefenceValue} <br></br></Text>
                        <Text color={'goldenrod'}>Price: {armour.price} gold<br></br></Text>
                        <Text color={'orange.400'}>{armour.flavourText}<br></br><br></br></Text>
                    </Box>
                ))}
            </Box>
            <Heading p={4}>Potions</Heading>
            <Box>
                {potions.map(potions => (
                    <Box p={4} borderWidth={1} borderRadius="lg">
                        <Text key={potions.potionId} color={'purple.600'} fontSize='2xl'>{potions.name}<br></br></Text>
                        <Text color={'orange.400'}>Effect: {potions.potionDescription}<br></br></Text>
                        <Text color={'red.600'}>Potency: {potions.potionPotencyValue}<br></br></Text>
                        <Text color={'goldenrod'}>Price: {potions.price} gold<br></br><br></br></Text>
                    </Box>
                ))}
            </Box>
        </Box>
    )
}
export default Home;