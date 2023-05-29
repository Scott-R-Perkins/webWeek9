import React, { useState, useEffect } from 'react';
import { Box, Button, Input, Heading, Spinner, Text, VStack, HStack, Flex, Select } from '@chakra-ui/react';

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
    const [itemName, setItemName] = useState("");
    const [itemPrice, setItemPrice] = useState(0);
    const [itemImgURL, setItemImgURL] = useState("");
    const [itemId, setItemId] = useState(null);
    const [itemType, setItemType] = useState("");
    const [itemToEdit, setItemToEdit] = useState(null);


    useEffect(() => {
        fetchWeapons();
        fetchArmour();
        fetchPotions();
    }, []);

    const fetchWeapons = async () => {
        fetch(`${baseURL}/Weapon`)
            .then(response => response.json())
            .then(data => setWeapons(data))
            .finally(() => setLoading(false));
    }
    
    const fetchArmour = async () => {
        fetch(`${baseURL}/Armour`)
            .then(response => response.json())
            .then(data => setArmours(data))
            .finally(() => setLoading(false));
    }
    
    const fetchPotions = async () => {
        fetch(`${baseURL}/Potion`)
            .then(response => response.json())
            .then(data => setPotions(data))
            .finally(() => setLoading(false));
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

    const deleteItem = async (itemId, itemType) => {
        await fetch(`${baseURL}/${itemType}/${itemId}`, {
            method: 'DELETE',
        })
            .then(response => response.json())
            .then(() => {
                if (itemType === 'Weapon') {
                    setWeapons(weapons.filter(weapon => weapon.id !== itemId));
                } else if (itemType === 'Armour') {
                    setArmours(armours.filter(armour => armour.id !== itemId));
                } else if (itemType === 'Potion') {
                    setPotions(potions.filter(potion => potion.id !== itemId));
                }
            });
    }

    const updateItem = async (itemId) => {
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
        setItemToEdit(null);
        await fetch(`${baseURL}/${itemType}/${itemId}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(body)
        })
            .then(response => response.json())
            .then(data => {
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
    
            {loading ? <Spinner /> : (
                <>
                    <VStack spacing={4}>
                        {['Weapon', 'Armour', 'Potion'].map((itemType) => (
                            <Box key={itemType}>
                                <Heading size="md" mb={4}>{itemType}s</Heading>
                                {[weapons, armours, potions][['Weapon', 'Armour', 'Potion'].indexOf(itemType)].map((item) => (
                                    <HStack key={item.id} spacing={4}>
                                        <Text>{item.name}</Text>
                                        <Button colorScheme="orange" onClick={() => { setItemToEdit(item); setItemType(itemType); }}>Edit</Button>
                                        <Button colorScheme="red" onClick={() => { deleteItem(item.id, itemType); }}>Delete</Button>
                                    </HStack>
                                ))}
                            </Box>
                        ))}
                    </VStack>
    
                    <Heading size="lg" my={6}>Add / Edit Item</Heading>
    
                    <Select placeholder="Select item type" mb={6} value={itemType} onChange={(e) => setItemType(e.target.value)}>
                        <option value="Weapon">Weapon</option>
                        <option value="Armour">Armour</option>
                        <option value="Potion">Potion</option>
                    </Select>
    
                    <Input placeholder='Item Name' mb={6} value={itemName} onChange={(e) => setItemName(e.target.value)} />
                    <Input type='number' placeholder='Price' mb={6} value={itemPrice} onChange={(e) => setItemPrice(e.target.value)} />
                    <Input placeholder='Image URL' mb={6} value={itemImgURL} onChange={(e) => setItemImgURL(e.target.value)} />
    
                    {itemType === 'Weapon' && (
                        <>
                            <Input type='number' placeholder='Attack Value' mb={6} value={attackValue} onChange={(e) => setAttackValue(e.target.value)} />
                            <Input type='number' placeholder='Attack Speed' mb={6} value={attackSpeed} onChange={(e) => setAttackSpeed(e.target.value)} />
                            <Input type='number' placeholder='DPS' mb={6} value={dps} onChange={(e) => setDps(e.target.value)} />
                            <Input type='number' placeholder='Ability Damage Modifier' mb={6} value={abilityDamageModifier} onChange={(e) => setAbilityDamageModifier(e.target.value)} />
                        </>
                    )}
                    {itemType === 'Armour' && (
                        <>
                            <Input type='number' placeholder='Physical Defence Value' mb={6} value={physicalDefenceValue} onChange={(e) => setPhysicalDefenceValue(e.target.value)} />
                            <Input type='number' placeholder='Magical Defence Value' mb={6} value={magicalDefenceValue} onChange={(e) => setMagicalDefenceValue(e.target.value)} />
                        </>
                    )}
                    {itemType === 'Potion' && (
                        <>
                            <Input placeholder='Potion Description' mb={6} value={potionDescription} onChange={(e) => setPotionDescription(e.target.value)} />
                            <Input type='number' placeholder='Potion Potency Value' mb={6} value={potionPotencyValue} onChange={(e) => setPotionPotencyValue(e.target.value)} />
                        </>
                    )}
    
                    <Button colorScheme="teal" mb={6} onClick={itemToEdit ? () => updateItem(itemToEdit.id) : addItem}>
                        {itemToEdit ? 'Update Item' : 'Add Item'}
                    </Button>
                </>
            )}
        </Flex>
    );
    
    

}

export default ShopAdmin;
