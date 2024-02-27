library IEEE;
use IEEE.Std_logic_1164.all;
use IEEE.Numeric_Std.all;

entity LeftShiftParallelRegister_tb is
end;

architecture bench of LeftShiftParallelRegister_tb is

  component LeftShiftParallelRegister
      Port ( CLK : in STD_LOGIC;
             RESET : in STD_LOGIC;
             SHIFT : in STD_LOGIC;
             DATAIN : in STD_LOGIC_VECTOR (3 downto 0);
             DATAOUT : out STD_LOGIC_VECTOR (7 downto 0));
  end component;

  signal CLK: STD_LOGIC;
  signal RESET: STD_LOGIC;
  signal SHIFT: STD_LOGIC;
  signal DATAIN: STD_LOGIC_VECTOR (3 downto 0);
  signal DATAOUT: STD_LOGIC_VECTOR (7 downto 0);
  -- ???????? ?? ??????? ?? ???????? ??????
  constant clock_period: time := 10 ns;
  signal stop_the_clock: boolean;

begin

  uut: LeftShiftParallelRegister port map ( CLK     => CLK,
                                            RESET   => RESET,
                                            SHIFT   => SHIFT,
                                            DATAIN  => DATAIN,
                                            DATAOUT => DATAOUT );

  stimulus: process
  begin
  
   -- ???????? ?? ????? ???????
    RESET <= '1';
    wait for 5 ns;
    RESET <= '0';
    wait for 5 ns;

    
    SHIFT <= '1'; -- ?????????? ?? ??????????? ??????
    DATAIN <= "0101";
    wait for 20 ns;

    
    SHIFT <= '1';
    DATAIN <= "1110";
    wait for 20 ns;

   
    SHIFT <= '1';
    DATAIN <= "0001";
    wait for 20 ns;

 
    SHIFT <= '1';
    DATAIN <= "1001";
    wait for 20 ns;

   
    stop_the_clock <= true;
    wait;
  end process;

  clocking: process
  begin
    while not stop_the_clock loop
      CLK <= '0', '1' after clock_period / 2;-- ?????????? ?? ?????? ??????
      wait for clock_period;
    end loop;
    wait;
  end process;

end;
