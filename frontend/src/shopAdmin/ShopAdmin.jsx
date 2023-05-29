import React, { useState, useEffect } from 'react';
import { Box, Button, Input, FormLabel, FormControl, Heading, Spinner, Text, VStack, HStack } from '@chakra-ui/react';

const ShopAdmin = () => {
    const [weapons, setWeapons] = useState([])
    const [armours, setArmours] = useState([])
    const [potions, setPotions] = useState([])
    const [loading, setLoading] = useState(true);
    const baseURL = "http://localhost:8000/api";
    const [attackValue, setAttackValue] = useState(null);
    const [attackSpeed, setAttackSpeed] = useState(null);
    const [dps, setDps] = useState(null);
    const [abilityDamageModifier, setAbilityDamageModifier] = useState(null);
    const [physicalDefenceValue, setPhysicalDefenceValue] = useState(null);
    const [magicalDefenceValue, setMagicalDefenceValue] = useState(null);
    const [potionDescription, setPotionDescription] = useState(null);
    const [potionPotencyValue, setPotionPotencyValue] = useState(null);

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

    const addItem = async () => {
        let body = {
            name: itemName,
            price: itemPrice,
            imgURL: itemImgURL
        };
    
        if (itemType === 'Weapon') {
            body = {
                ...body,
                attackValue,
                attackSpeed,
                dps,
                abilityDamageModifier
            };
        } else if (itemType === 'Armour') {
            body = {
                ...body,
                physicalDefenceValue,
                magicalDefenceValue
            };
        } else if (itemType === 'Potion') {
            body = {
                ...body,
                potionDescription,
                potionPotencyValue
            };
        }
    
        await fetch(`${baseURL}/${itemType}`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(body)
        }).then(response => response.json())
        .then(data => {
            alert(`Successfully added ${data.name}!`);
        });
        
    };

    const deleteItem = async () => {
        // Use the item ID for deletion
        await fetch(`${baseURL}/${itemType}/${itemId}`, {
            method: 'DELETE',
        })
            .then(response => response.json())
            .then(() => {
                // Filter the deleted item out of the current items
                if (itemType === 'Weapon') {
                    setWeapons(weapons.filter(weapon => weapon.id !== itemId));
                } else if (itemType === 'Armour') {
                    setArmours(armours.filter(armour => armour.id !== itemId));
                } else if (itemType === 'Potion') {
                    setPotions(potions.filter(potion => potion.id !== itemId));
                }
            });
    }

    const updateItem = async () => {
        let body = {
            name: itemName,
            price: itemPrice,
        };
    
        if (itemType === 'Weapon') {
            body = {
                ...body,
                attackValue,
                attackSpeed,
                dps,
                abilityDamageModifier
            };
        } else if (itemType === 'Armour') {
            body = {
                ...body,
                physicalDefenceValue,
                magicalDefenceValue
            };
        } else if (itemType === 'Potion') {
            body = {
                ...body,
                potionDescription,
                potionPotencyValue
            };
        }
    
        // Use the item ID for updating
        await fetch(`${baseURL}/${itemType}/${itemId}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(body)
        })
            .then(response => response.json())
            .then(data => {
                // Update the item in the current items
                if (itemType === 'Weapon') {
                    setWeapons(weapons.map(weapon => weapon.id === itemId ? data : weapon));
                } else if (itemType === 'Armour') {
                    setArmours(armours.map(armour => armour.id === itemId ? data : armour));
                } else if (itemType === 'Potion') {
                    setPotions(potions.map(potion => potion.id === itemId ? data : potion));
                }
            });
    }
    


    if (loading) return <Spinner />;

    return (
        <Flex direction="column" p={12} boxSize="full" alignItems="center">
            <Heading mb={6}>Shop Editor</Heading>
    
            <Select placeholder="Select item type" mb={6} onChange={(e) => setItemType(e.target.value)}>
                <option value="Weapon">Weapon</option>
                <option value="Armour">Armour</option>
                <option value="Potion">Potion</option>
            </Select>
    
            <Input placeholder='Item Name' mb={6} onChange={(e) => setItemName(e.target.value)} />
            <Input type='number' placeholder='Price' mb={6} onChange={(e) => setItemPrice(e.target.value)} />
            <Input placeholder='Image URL' mb={6} onChange={(e) => setItemImgURL(e.target.value)} />
    
            {itemType === 'Weapon' && (
                <>
                    <Input type='number' placeholder='Attack Value' mb={6} onChange={(e) => setAttackValue(e.target.value)} />
                    <Input type='number' placeholder='Attack Speed' mb={6} onChange={(e) => setAttackSpeed(e.target.value)} />
                    <Input type='number' placeholder='DPS' mb={6} onChange={(e) => setDps(e.target.value)} />
                    <Input type='number' placeholder='Ability Damage Modifier' mb={6} onChange={(e) => setAbilityDamageModifier(e.target.value)} />
                </>
            )}
            {itemType === 'Armour' && (
                <>
                    <Input type='number' placeholder='Physical Defence Value' mb={6} onChange={(e) => setPhysicalDefenceValue(e.target.value)} />
                    <Input type='number' placeholder='Magical Defence Value' mb={6} onChange={(e) => setMagicalDefenceValue(e.target.value)} />
                </>
            )}
            {itemType === 'Potion' && (
                <>
                    <Input placeholder='Potion Description' mb={6} onChange={(e) => setPotionDescription(e.target.value)} />
                    <Input type='number' placeholder='Potion Potency Value' mb={6} onChange={(e) => setPotionPotencyValue(e.target.value)} />
                </>
            )}
    
            <Button colorScheme="teal" mb={6} onClick={addItem}>Add Item</Button>
    
            <Input placeholder='Item ID' mb={6} onChange={(e) => setItemId(e.target.value)} />
            <Button colorScheme="orange" mb={6} onClick={updateItem}>Update Item</Button>
            <Button colorScheme="red" mb={6} onClick={deleteItem}>Delete Item</Button>
        </Flex>
    );
    

}

export default ShopAdmin;
