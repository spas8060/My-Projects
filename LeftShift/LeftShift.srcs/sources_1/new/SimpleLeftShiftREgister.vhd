library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

entity LeftShiftParallelRegister is
    Port ( CLK : in STD_LOGIC;
           RESET : in STD_LOGIC;
           SHIFT : in STD_LOGIC;        
           DATAIN : in STD_LOGIC_VECTOR (3 downto 0);
           DATAOUT : out STD_LOGIC_VECTOR (7 downto 0));
end LeftShiftParallelRegister;

architecture Behavioral of LeftShiftParallelRegister is

    signal A : std_logic_vector(7 downto 0);
begin
    process (CLK, RESET)
    begin
        if RESET = '1' then
            A <= (others => '0'); 
        elsif rising_edge(CLK) then
            if SHIFT = '1' then
                A <= A(3 downto 0) & DATAIN; 
            end if;
        end if;
    end process;

    DATAOUT <= A;
end Behavioral;
