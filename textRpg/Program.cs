using System.ComponentModel.Design;

namespace textRpg
{
    
    
    internal class Program
    {
        //화면 만들기 - 메인화면
        //화면 만들기 - 상태보기
        //화면 만들기 - 인벤토리
        //화면 만들기 - 인벤토리 [장착관리]
        //화면 만들기 - 상점
        //화면 만들기 - 상점 [구매]

        // 기능1 [All] - 선택한 화면으로 이동하기
        // 기능2 [Stat] - 캐릭터 정보 표시(변경되는 정보를 확인) - 레벨 / 이름 / 직업 / 공격력 / 방어력 / 체력 / Gold
        // 기능2-1 [Stat] - 장비 반영에 따른 정보 - 공격력/방어력
        // 기능3 [Inventory] - 보유 아이템 표시(인벤토리)
        // 기능4 [Inventory] - 장비 장착
        // 기능5 [Shop] - 상점 리스트 표시
        // 기능6 [Shop] - 구매 기능

        // 캐릭터 정보
        // - 레벨 / 이름 / 직업 / 공격력 / 방어력 / 체력 / Gold
        // 추가 공격력 / 추가 방어력

        // 아이템 정보
        // 이름 / 장비타입 / 장비의 밸류 / 설명 / 가격

        // 인벤토리
        

        static void Main(string[] args)
        {
            int level = 1;
            string playerName;
            string job = "전사";
            int attack = 10;
            int defense = 5;
            int hp = 100;
            int gold = 1500;

            int[] price = { 1000, 800, 3500, 600, 1500, 500 };
            string[] itemName = { "수련자 갑옷", "무쇠갑옷", "스파르타의 갑옷", "낡은 검", "청동 도끼", "스파르타의 창" };
            int[] def = { 5, 9, 15 };
            int[] att = { 2, 5, 7 };
            int[] select = { 1, 2, 3, 4, 5, 6 };

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");

                Console.WriteLine("1. 상태보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점\n");

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">>");

                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        {
                            // 상태창
                            Console.Clear();
                            Console.WriteLine("상태보기");
                            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");

                            // 레벨, 이름, 직업, 공격력, 방어력, 체력, gold
                            Console.WriteLine("Lv. " + level);
                            Console.WriteLine($"Chad ( {job} )");
                            Console.WriteLine("공격력 : " + attack);
                            Console.WriteLine("방어력 : " + defense);
                            Console.WriteLine("체력 : " + hp);
                            Console.WriteLine($"Gold : {gold} G\n");

                            Console.WriteLine("0. 나가기\n");

                            Console.WriteLine("원하시는 행동을 입력해주세요.");
                            Console.Write(">>");

                            int action = int.Parse(Console.ReadLine());

                            if (action == 0)
                            {                                
                                break;
                            }
                            break;
                        }

                    case 2:
                        {
                            // 인벤토리
                            Console.Clear();
                            Console.WriteLine("인벤토리");
                            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

                            Console.WriteLine("[아이템 목록]\n");
                                           

                            Console.WriteLine("1. 장착 관리");
                            Console.WriteLine("0. 나가기\n");

                            Console.WriteLine("원하시는 행동을 입력해주세요.");
                            Console.Write(">>");

                            int action = int.Parse(Console.ReadLine());

                            if (action == 0)
                            {
                                break;
                            }
                            break;
                        }

                    case 3:
                        {
                            // 상점
                            Console.Clear();
                            Console.WriteLine("상점");
                            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");

                            Console.WriteLine("[보유 골드]");
                            Console.WriteLine($"{gold} G\n");

                                                  

                            Console.WriteLine("[아이템 목록]");
                            Console.WriteLine("- 수련자 갑옷  | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.  |  1000 G");
                            Console.WriteLine("- 무쇠갑옷  | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.  |  800 G");
                            Console.WriteLine("- 스파르타의 갑옷 | 방어력 + 15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.| 3500 G");
                            Console.WriteLine("- 낡은 검 | 공격력 + 2 | 쉽게 볼 수 있는 낡은 검 입니다.  | 600 G");
                            Console.WriteLine("- 청동 도끼 | 공격력 + 5 | 어디선가 사용됐던거 같은 도끼입니다.  | 1500 G");
                            Console.WriteLine("- 스파르타의 창 | 공격력 + 7 | 스파르타의 전사들이 사용했다는 전설의 창입니다. | 500 G\n");    

                            Console.WriteLine("1. 아이템 구매");
                            Console.WriteLine("0. 나가기\n");

                            Console.WriteLine("원하시는 행동을 입력해주세요.");
                            Console.Write(">>");

                            int action = int.Parse(Console.ReadLine());

                            if (action == 0)
                            {
                                break;
                            }
                            else if(action == 1) // 아이템 구매
                            {
                                Console.Clear();
                                Console.WriteLine("상점");
                                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");

                                Console.WriteLine("[보유 골드]");
                                Console.WriteLine($"{gold} G\n");

                                Console.WriteLine("[아이템 목록]");
                                Console.WriteLine("- " + select[0] + " " + itemName[0] + "   | 방어력 +" + def[0] + "  | 수련에 도움을 주는 갑옷입니다.  |  " + price[0] + "G");
                                Console.WriteLine("- " + select[1] + " " + itemName[1] + "   | 방어력 +" + def[1] + "  | 무쇠로 만들어져 튼튼한 갑옷입니다.  |  " + price[1] + "G");
                                Console.WriteLine("- " + select[2] + " " + itemName[2] + "   | 방어력 +" + def[2] + "  | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.  |  " + price[2] + "G");
                                Console.WriteLine("- " + select[3] + " " + itemName[3] + "   | 공격력 +" + att[0] + " | 쉽게 볼 수 있는 낡은 검 입니다.  |  " + price[3] + "G");
                                Console.WriteLine("- " + select[4] + " " + itemName[4] + "   | 공격력 +" + att[1] + "  | 어디선가 사용됐던거 같은 도끼입니다.  |  " + price[4] + "G");
                                Console.WriteLine("- " + select[5] + " " + itemName[5] + "   | 공격력 +" + att[2] + "  | 스파르타의 전사들이 사용했다는 전설의 창입니다.  |  " + price[5] + "G\n");

                                Console.WriteLine("0. 나가기\n");

                                Console.WriteLine("원하시는 행동을 입력해주세요.");
                                Console.Write(">>");
                                int itemChoice = int.Parse(Console.ReadLine());

                                if (itemChoice >= 1 && itemChoice <= 6) // 숫자입력
                                {                                                                  
                                   
                                }
                                else
                                {
                                    Console.WriteLine("잘못된 입력입니다");
                                }
                               
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.\n");
                            break;
                        }
                }
            }
        }

    }
}