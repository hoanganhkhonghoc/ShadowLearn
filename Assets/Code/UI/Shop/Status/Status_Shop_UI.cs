using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Status_Shop_UI : MonoBehaviour
{

    [SerializeField] private Sprite tree_item;
    [SerializeField] private Sprite tree_cut;
    [SerializeField] private Sprite land;
    [SerializeField] private Sprite fire;

    [SerializeField] private Sprite treeGod;
    [SerializeField] private Sprite HurryGod;
    [SerializeField] private Sprite player;

    [SerializeField] private Sprite itemGo;
    [SerializeField] private Sprite itemHat;
    [SerializeField] private Sprite itemSat;
    [SerializeField] private Sprite itemBanhMiB;
    [SerializeField] private Sprite itemBanhMiA;
    [SerializeField] private Sprite itemBanhMiS;
    [SerializeField] private Sprite itemPhoMaiS;
    [SerializeField] private Sprite itemHome;

    [SerializeField] private Sprite KeyF;
    [SerializeField] private Sprite KeyT;
    [SerializeField] private Sprite KeyY;

    [SerializeField] private Image image;
    [SerializeField] private Image imageButton;

    [SerializeField] private TextMeshProUGUI nameItem;
    // nguyên liệu
    [SerializeField] private TextMeshProUGUI nl_Go;
    [SerializeField] private TextMeshProUGUI nl_Hat;
    [SerializeField] private TextMeshProUGUI nl_Sat;
    // vật phẩm thu thập
    [SerializeField] private TextMeshProUGUI vp_Go;
    [SerializeField] private TextMeshProUGUI vp_Hat;
    [SerializeField] private TextMeshProUGUI vp_Sat;
    [SerializeField] private TextMeshProUGUI vp_BanhMiB;
    [SerializeField] private TextMeshProUGUI vp_BanhMiA;
    [SerializeField] private TextMeshProUGUI vp_BanhMiS;
    [SerializeField] private TextMeshProUGUI vp_PhoMaiS;
    // thông tin
    [SerializeField] private TextMeshProUGUI statusItem;
    public void StatusItems(int id)
    {
        switch (id)
        {
            case 1:
                Case1();
                break;
            case 2:
                Case2();
                break;
            case 3:
                Case3();
                break;
            case 4:
                Case4();
                break;
            case 5:
                Case5();
                break;
            case 6:
                Case6();
                break;
            case 7:
                Case7();
                break;
            case 8:
                Case8();
                break;
            case 9:
                Case9();
                break;
            case 10:
                Case10();
                break;
            case 11:
                Case11();
                break;
            case 12:
                Case12();
                break;

        }
    }
    private void Case1()
    {
        image.sprite = tree_item;

        nameItem.text = "Tên: Bụi cây ma quái";

        nl_Go.text = "0";
        nl_Hat.text = "1";
        nl_Sat.text = "0";

        vp_Go.text = "0";
        vp_Hat.text = "1";
        vp_BanhMiB.text = "?";
        vp_BanhMiA.text = "?";
        vp_BanhMiS.text = "?";
        vp_PhoMaiS.text = "?";

        statusItem.text = "Bụi cây có thể tạo ra lương thực đủ cho bạn sống tiếp ở thế giới này."+"\n"+"Thời gian thu thập: 120 giây.";
        imageButton.sprite = KeyT;
    }

    private void Case2()
    {
        image.sprite = tree_cut;

        nameItem.text = "Tên: Cây";

        nl_Go.text = "0";
        nl_Hat.text = "0";
        nl_Sat.text = "0";

        vp_Go.text = "1";
        vp_Hat.text = "0";
        vp_BanhMiB.text = "0";
        vp_BanhMiA.text = "0";
        vp_BanhMiS.text = "0";
        vp_PhoMaiS.text = "0";

        statusItem.text = "Cây sẽ giúp bạn thu thập Gỗ để tạo vật phẩm." + "\n" + "Thời gian mọc lại: 90 giây.";
        imageButton.sprite = KeyF;
    }

    private void Case3()
    {
        image.sprite = land;

        nameItem.text = "Tên: Đất trồng cây";

        nl_Go.text = "0";
        nl_Hat.text = "1";
        nl_Sat.text = "0";

        vp_Go.text = "0";
        vp_Hat.text = "0";
        vp_BanhMiB.text = "0";
        vp_BanhMiA.text = "0";
        vp_BanhMiS.text = "0";
        vp_PhoMaiS.text = "0";

        statusItem.text = "Đất sẽ cần để cho bụi cây ma quái." + "\n" + "Thời gian mọc lại: 120 giây.";
        imageButton.sprite = KeyF;
    }

    private void Case4()
    {
        image.sprite = fire;

        nameItem.text = "Tên: Ngọn lửa";

        nl_Go.text = "1";
        nl_Hat.text = "0";
        nl_Sat.text = "0";

        vp_Go.text = "0";
        vp_Hat.text = "0";
        vp_BanhMiB.text = "0";
        vp_BanhMiA.text = "0";
        vp_BanhMiS.text = "0";
        vp_PhoMaiS.text = "0";

        statusItem.text = "Ngọn lửa sẽ giúp soi sáng phạm vi xung quanh." + "\n" + "Thời gian tồn tại: 30 giây.";
        imageButton.sprite = KeyF;
    }

    private void Case5()
    {
        image.sprite = treeGod;

        nameItem.text = "Tên: Thần cây";

        nl_Go.text = "0";
        nl_Hat.text = "0";
        nl_Sat.text = "0";

        vp_Go.text = "0";
        vp_Hat.text = "0";
        vp_BanhMiB.text = "0";
        vp_BanhMiA.text = "0";
        vp_BanhMiS.text = "0";
        vp_PhoMaiS.text = "0";

        statusItem.text = "Thần cây là người cai quoản vùng đất này. Đừng phá hoại!!.";
        imageButton.sprite = null;
    }

    private void Case6()
    {
        image.sprite = HurryGod;

        nameItem.text = "Tên: Thần đói";

        nl_Go.text = "0";
        nl_Hat.text = "0";
        nl_Sat.text = "0";

        vp_Go.text = "0";
        vp_Hat.text = "0";
        vp_BanhMiB.text = "0";
        vp_BanhMiA.text = "0";
        vp_BanhMiS.text = "0";
        vp_PhoMaiS.text = "0";

        statusItem.text = "Thần đói sẽ xuất hiện khi đêm xuống ở những nơi đen tối nhất. Hãy đi tới nơi sáng!!";
        imageButton.sprite = null;
    }

    private void Case7()
    {
        image.sprite = player;

        nameItem.text = "Tên: Đứa trẻ mồ côi";

        nl_Go.text = "0";
        nl_Hat.text = "0";
        nl_Sat.text = "0";

        vp_Go.text = "0";
        vp_Hat.text = "0";
        vp_BanhMiB.text = "0";
        vp_BanhMiA.text = "0";
        vp_BanhMiS.text = "0";
        vp_PhoMaiS.text = "0";

        statusItem.text = "Có 500Hp ban đầu và giảm dần theo từng giây, có thể hồi Hp bằng cách ăn uống. Đừng để đói!!";
        imageButton.sprite = null;
    }

    private void Case8()
    {
        image.sprite = itemHome;

        nameItem.text = "Tên: Nhà gỗ";

        nl_Go.text = "20";
        nl_Hat.text = "0";
        nl_Sat.text = "0";

        vp_Go.text = "0";
        vp_Hat.text = "0";
        vp_BanhMiB.text = "0";
        vp_BanhMiA.text = "0";
        vp_BanhMiS.text = "0";
        vp_PhoMaiS.text = "0";

        statusItem.text = "Nhà sẽ giúp bạn có thể tránh được các khoảng tối cũng như là một nơi an toàn tạm thời cho bạn";
        imageButton.sprite = KeyY;
    }

    private void Case9()
    {
        image.sprite = itemBanhMiB;

        nameItem.text = "Tên: Bánh mì thường";

        nl_Go.text = "0";
        nl_Hat.text = "0";
        nl_Sat.text = "0";

        vp_Go.text = "0";
        vp_Hat.text = "0";
        vp_BanhMiB.text = "0";
        vp_BanhMiA.text = "0";
        vp_BanhMiS.text = "0";
        vp_PhoMaiS.text = "0";

        statusItem.text = "Bánh mì sẽ giúp bạn không bị đói. Có thể hồi 100hp mỗi lần sử dụng";
        imageButton.sprite = KeyT;
    }

    private void Case10()
    {
        image.sprite = itemBanhMiA;

        nameItem.text = "Tên: Bánh mì cao cấp";

        nl_Go.text = "0";
        nl_Hat.text = "0";
        nl_Sat.text = "0";

        vp_Go.text = "0";
        vp_Hat.text = "0";
        vp_BanhMiB.text = "0";
        vp_BanhMiA.text = "0";
        vp_BanhMiS.text = "0";
        vp_PhoMaiS.text = "0";

        statusItem.text = "Bánh mì sẽ giúp bạn không bị đói. Có thể hồi 300hp mỗi lần sử dụng";
        imageButton.sprite = KeyT;
    }

    private void Case11()
    {
        image.sprite = itemBanhMiS;

        nameItem.text = "Tên: Bánh mì kẹp thịt";

        nl_Go.text = "0";
        nl_Hat.text = "0";
        nl_Sat.text = "0";

        vp_Go.text = "0";
        vp_Hat.text = "0";
        vp_BanhMiB.text = "0";
        vp_BanhMiA.text = "0";
        vp_BanhMiS.text = "0";
        vp_PhoMaiS.text = "0";

        statusItem.text = "Bánh mì loại cực hiếm giúp bạn hồi lại sinh lực ngay lập tức đừng để chúng lãng phí.";
        imageButton.sprite = KeyT;
    }

    private void Case12()
    {
        image.sprite = itemPhoMaiS;

        nameItem.text = "Tên: Phô mai quái vật";

        nl_Go.text = "0";
        nl_Hat.text = "0";
        nl_Sat.text = "0";

        vp_Go.text = "0";
        vp_Hat.text = "0";
        vp_BanhMiB.text = "0";
        vp_BanhMiA.text = "0";
        vp_BanhMiS.text = "0";
        vp_PhoMaiS.text = "0";

        statusItem.text = "Phô mai cực phẩm sẽ giúp bạn hồi lại sinh lực ngay lập tức đừng để chúng lãng phí.";
        imageButton.sprite = KeyT;
    }
}
