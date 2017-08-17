using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Models.LOLSkins
{

    public class Champions
    {
        public List<Champion> List;
        public Champions(string LoLPath, string imgPath, string particles)
        {
            this.List = new List<Champion>();
            Champion champion = new Champion("A-阿狸·九尾妖狐", "Ahri")
            {
                New = false
            };
            Skin skin = new Skin("经典")
            {
                Files = 
				{
					"AhriLoadScreen.dds",
					"Ahri_base_TX_CM.dds",
					"Ahri.skl",
					"Ahri.skn",
					"Animations\\Ahri_dance.anm"
				},
                Image = LoLPath + imgPath + "Ahri_0.jpg",
                Background = LoLPath + imgPath + "Ahri_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("高丽风情")
            {
                Files = 
				{
					"AhriLoadScreen_1.dds",
					"Ahri_hanbok_TX_CM.dds",
					"Ahri_hanbok.skl",
					"Ahri_hanbok.skn",
					"Animations\\Ahri_hanbok_dance.anm"
				},
                Image = LoLPath + imgPath + "Ahri_1.jpg",
                Background = LoLPath + imgPath + "Ahri_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("暗影妖狐")
            {
                Files = 
				{
					"AhriLoadScreen_2.dds",
					"Ahri_shadowFox_TX_CM.dds",
					"Ahri_shadowfox.skl",
					"Ahri_shadowfox.skn"
				},
                Image = LoLPath + imgPath + "Ahri_2.jpg",
                Background = LoLPath + imgPath + "Ahri_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("焰尾妖狐")
            {
                Files = 
				{
					"AhriLoadScreen_3.dds",
					"Ahri_fire_TX_CM.dds",
					"Ahri_fire.skl",
					"Ahri_fire.skn"
				},
                Image = LoLPath + imgPath + "Ahri_3.jpg",
                Background = LoLPath + imgPath + "Ahri_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("A-阿卡丽·暗影之拳", "Akali")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"AkaliLoadScreen.dds",
					"akali.dds",
					"Akali.skl",
					"Akali.skn"
				},
                Image = LoLPath + imgPath + "Akali_0.jpg",
                Background = LoLPath + imgPath + "Akali_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("蜂刺")
            {
                Files = 
				{
					"AkaliLoadScreen_1.dds",
					"Akali_Yellow_TX_CM.dds",
					"Akali.skl",
					"Akali.skn"
				},
                Image = LoLPath + imgPath + "Akali_1.jpg",
                Background = LoLPath + imgPath + "Akali_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("绯红")
            {
                Files = 
				{
					"AkaliLoadScreen_2.dds",
					"Akali_Red_TX_CM.dds",
					"Akali.skl",
					"Akali.skn"
				},
                Image = LoLPath + imgPath + "Akali_2.jpg",
                Background = LoLPath + imgPath + "Akali_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("足球宝贝")
            {
                Files = 
				{
					"AkaliLoadScreen_3.dds",
					"Akali_Soccer_TX_CM.dds",
					"Akali_soccer.skl",
					"Akali_soccer.skn"
				},
                Image = LoLPath + imgPath + "Akali_3.jpg",
                Background = LoLPath + imgPath + "Akali_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("实习护士")
            {
                Files = 
				{
					"AkaliLoadScreen_4.dds",
					"akali_nurse_TX_CM.dds",
					"Akali_nurse.skl",
					"Akali_nurse.skn"
				},
                Image = LoLPath + imgPath + "Akali_4.jpg",
                Background = LoLPath + imgPath + "Akali_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("鬼武姬")
            {
                Files = 
				{
					"AkaliLoadScreen_5.dds",
					"akali_oni_TX_CM.dds",
					"Akali_oni.skl",
					"Akali_oni.skn"
				},
                Image = LoLPath + imgPath + "Akali_5.jpg",
                Background = LoLPath + imgPath + "Akali_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("银色之牙")
            {
                Files = 
				{
					"AkaliLoadScreen_6.dds",
					"Akali_mercenary_TX_CM.dds",
					"Akali_mercenary.skl",
					"Akali_mercenary.skn"
				},
                Image = LoLPath + imgPath + "Akali_6.jpg",
                Background = LoLPath + imgPath + "Akali_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("A-阿里斯塔·牛头酋长", "Alistar")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"AlistarLoadScreen.dds",
					"Minotaur_Diffuse.dds",
					"alistar.skl",
					"alistar.skn",
					"Animations\\alistar_dance.anm",
					"Animations\\alistar_death.anm",
					"Animations\\alistar_spell1.anm",
					"Animations\\alistar_taunt.anm"
				},
                Image = LoLPath + imgPath + "Alistar_0.jpg",
                Background = LoLPath + imgPath + "Alistar_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("暗黑灵魂")
            {
                Files = 
				{
					"AlistarLoadScreen_1.dds",
					"Minotaur2Black_Diffuse.dds"
				},
                Image = LoLPath + imgPath + "Alistar_1.jpg",
                Background = LoLPath + imgPath + "Alistar_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("金牛座")
            {
                Files = 
				{
					"AlistarLoadScreen_2.dds",
					"Minotaur_golden_Diffuse.dds"
				},
                Image = LoLPath + imgPath + "Alistar_2.jpg",
                Background = LoLPath + imgPath + "Alistar_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("斗牛士")
            {
                Files = 
				{
					"AlistarLoadScreen_3.dds",
					"Alistar_Matador_TX_CM.dds",
					"Alistar_Matador.skl",
					"Alistar_Matador.skn"
				},
                Image = LoLPath + imgPath + "Alistar_3.jpg",
                Background = LoLPath + imgPath + "Alistar_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("荒野镖客")
            {
                Files = 
				{
					"AlistarLoadScreen_4.dds",
					"alistar_cowboy_TX_CM.dds",
					"Alistar_cowboy.skl",
					"Alistar_cowboy.skn"
				},
                Image = LoLPath + imgPath + "Alistar_4.jpg",
                Background = LoLPath + imgPath + "Alistar_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("巨角幻兽")
            {
                Files = 
				{
					"AlistarLoadScreen_5.dds",
					"alistar_blue_TX_CM.dds",
					"alistar_blue.skl",
					"alistar_blue.skn",
					"Animations\\alistar_blue_dance.anm",
					"Animations\\alistar_blue_death.anm",
					"Animations\\alistar_blue_spell1.anm",
					"Animations\\alistar_blue_taunt.anm"
				},
                Image = LoLPath + imgPath + "Alistar_5.jpg",
                Background = LoLPath + imgPath + "Alistar_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("炼狱火魔")
            {
                Files = 
				{
					"AlistarLoadScreen_6.dds",
					"alistar_armored_TX_CM.dds",
					"alistar_armored.skl",
					"alistar_armored.skn",
					"Animations\\alistar_blue_dance.anm",
					"Animations\\alistar_armored_run_angry.anm",
					"Animations\alistar_blue_spell1.anm",
					"Animations\alistar_armored_Idle3.anm"
				},
                Image = LoLPath + imgPath + "Alistar_6.jpg",
                Background = LoLPath + imgPath + "Alistar_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("A-阿木木·殇之木乃伊", "Amumu")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"AmumuLoadScreen.dds",
					"SadMummy.dds",
					"Amumu.skl",
					"Amumu.skn",
					"Animations\\amumu_idle1.anm",
					"Animations\\amumu_run.anm",
					"Animations\\amumu_laugh.anm",
					"Animations\\amumu_taunt.anm"
				},
                Image = LoLPath + imgPath + "Amumu_0.jpg",
                Background = LoLPath + imgPath + "Amumu_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("法老")
            {
                Files = 
				{
					"AmumuLoadScreen_1.dds",
					"Amumu_Pharaoh.dds",
					"Amumu_Pharaoh.skl",
					"Amumu_Pharaoh.skn"
				},
                Image = LoLPath + imgPath + "Amumu_1.jpg",
                Background = LoLPath + imgPath + "Amumu_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("狂欢")
            {
                Files = 
				{
					"AmumuLoadScreen_2.dds",
					"Amumu_Olympic.dds",
					"Amumu_Olympic.skl",
					"Amumu_Olympic.skn"
				},
                Image = LoLPath + imgPath + "Amumu_2.jpg",
                Background = LoLPath + imgPath + "Amumu_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("情绪摇滚")
            {
                Files = 
				{
					"AmumuLoadScreen_3.dds",
					"amumu_emo_TX_CM.dds",
					"amumu_emo.skl",
					"amumu_emo.skn"
				},
                Image = LoLPath + imgPath + "Amumu_3.jpg",
                Background = LoLPath + imgPath + "Amumu_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("主人不要我了'")
            {
                Files = 
				{
					"AmumuLoadScreen_4.dds",
					"amumu_gift_TX_CM.dds",
					"amumu_regift.skl",
					"amumu_regift.skn",
					"Animations\\Amumu_regift_Idle1.anm",
					"Animations\\Amumu_regift_Run.anm",
					"Animations\\amumu_laugh.anm",
					"Animations\\amumu_taunt.anm"
				},
                Image = LoLPath + imgPath + "Amumu_4.jpg",
                Background = LoLPath + imgPath + "Amumu_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("王子不是我")
            {
                Files = 
				{
					"AmumuLoadScreen_5.dds",
					"amumu_prom_TX_CM.dds",
					"amumu_prom.skl",
					"amumu_prom.skn"
				},
                Image = LoLPath + imgPath + "Amumu_5.jpg",
                Background = LoLPath + imgPath + "Amumu_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("小小骑士")
            {
                Files = 
				{
					"AmumuLoadScreen_6.dds",
					"amumu_knight_TX_CM.dds",
					"amumu_knight.skl",
					"amumu_knight.skn",
					"Animations\\amumu_idle1.anm",
					"Animations\\amumu_run.anm",
					"Animations\\amumu_knight_laugh.anm",
					"Animations\\amumu_knight_taunt.anm"
				},
                Image = LoLPath + imgPath + "Amumu_6.jpg",
                Background = LoLPath + imgPath + "Amumu_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("殇之机器人")
            {
                Files = 
				{
					"AmumuLoadScreen_7.dds",
					"amumu_badrobot_TX_CM.dds",
					"amumu_badrobot.skl",
					"amumu_badrobot.skn"
				},
                Image = LoLPath + imgPath + "Amumu_7.jpg",
                Background = LoLPath + imgPath + "Amumu_Splash_7.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("A-艾尼维亚·冰晶凤凰", "Anivia")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"AniviaLoadScreen.dds",
					"Cryophoenix.dds",
					"Anivia.skl",
					"Anivia.skn"
				},
                Image = LoLPath + imgPath + "Anivia_0.jpg",
                Background = LoLPath + imgPath + "Anivia_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("双重冰晶")
            {
                Files = 
				{
					"AniviaLoadScreen_1.dds",
					"anivia_teamspirit_TX_CM.dds",
					"anivia_teamspirit.skl",
					"anivia_teamspirit.skn"
				},
                Image = LoLPath + imgPath + "Anivia_1.jpg",
                Background = LoLPath + imgPath + "Anivia_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("联盟之喙")
            {
                Files = 
				{
					"AniviaLoadScreen_2.dds",
					"Anivia_BaldEagle_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Anivia_2.jpg",
                Background = LoLPath + imgPath + "Anivia_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("重甲猎鹰")
            {
                Files = 
				{
					"AniviaLoadScreen_3.dds",
					"anivia_battlearmor_TX_CM.dds",
					"anivia_battlearmor.skl",
					"anivia_battlearmor.skn"
				},
                Image = LoLPath + imgPath + "Anivia_3.jpg",
                Background = LoLPath + imgPath + "Anivia_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("钢铁之翼")
            {
                Files = 
				{
					"AniviaLoadScreen_4.dds",
					"anivia_hextech_TX_CM.dds",
					"anivia_hextech.skl",
					"anivia_hextech.skn"
				},
                Image = LoLPath + imgPath + "Anivia_4.jpg",
                Background = LoLPath + imgPath + "Anivia_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("A-安妮·黑暗之女", "Annie")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"Skins\\Base\\AnnieLoadScreen.dds",
					"Skins\\Base\\annie_base_2012_CM.dds",
					"Skins\\Base\\Annie_2012.skl",
					"Skins\\Base\\Annie_2012.skn"
				},
                Image = LoLPath + imgPath + "Annie_0.jpg",
                Background = LoLPath + imgPath + "Annie_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("哥特萝莉")
            {
                Files = 
				{
					"Skins\\Skin01\\AnnieLoadScreen_1.dds",
					"Skins\\Skin01\\annie_goth_TX_CM.dds",
					"Skins\\Skin01\\Annie_Goth.skl",
					"Skins\\Skin01\\Annie_Goth.skn"
				},
                Image = LoLPath + imgPath + "Annie_1.jpg",
                Background = LoLPath + imgPath + "Annie_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("小红帽")
            {
                Files = 
				{
					"Skins\\Skin02\\AnnieLoadScreen_2.dds",
					"Skins\\Skin02\\Annie_littleRed.dds",
					"Skins\\Skin02\\Annie_littleRed.skl",
					"Skins\\Skin02\\Annie_littleRed.skn"
				},
                Image = LoLPath + imgPath + "Annie_2.jpg",
                Background = LoLPath + imgPath + "Annie_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("安妮梦游仙境")
            {
                Files = 
				{
					"Skins\\Skin03\\AnnieLoadScreen_3.dds",
					"Skins\\Skin03\\annie_wonderland_TX_CM.dds",
					"Skins\\Skin03\\annie_wonderland.skl",
					"Skins\\Skin03\\annie_wonderland.skn"
				},
                Image = LoLPath + imgPath + "Annie_3.jpg",
                Background = LoLPath + imgPath + "Annie_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("舞会公主")
            {
                Files = 
				{
					"Skins\\Skin04\\AnnieLoadScreen_4.dds",
					"Skins\\Skin04\\annie_prom_TX_CM.dds",
					"Skins\\Skin04\\Annie_prom.skl",
					"Skins\\Skin04\\Annie_prom.skn"
				},
                Image = LoLPath + imgPath + "Annie_4.jpg",
                Background = LoLPath + imgPath + "Annie_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冰霜烈焰⊙特效")
            {
                Files = 
				{
					"Skins\\Skin05\\AnnieLoadScreen_5.dds",
					"Skins\\Skin05\\Annie_FrostFire_TX_CM.dds",
					"Skins\\Skin05\\Annie_FrostFire.skl",
					"Skins\\Skin05\\Annie_FrostFire.skn"
				},
                Image = LoLPath + imgPath + "Annie_5.jpg",
                Background = LoLPath + imgPath + "Annie_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("安伯斯与提妮")
            {
                Files = 
				{
					"Skins\\Skin06\\AnnieLoadScreen_6.dds",
					"Skins\\Skin06\\annie_reverse_TX_CM.dds",
					"Skins\\Skin06\\annie_reverse.skl",
					"Skins\\Skin06\\annie_reverse.skn"
				},
                Image = LoLPath + imgPath + "Annie_6.jpg",
                Background = LoLPath + imgPath + "Annie_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("科学怪熊的新娘")
            {
                Files = 
				{
					"Skins\\Skin07\\AnnieLoadScreen_7.dds",
					"Skins\\Skin07\\annie_frankenstein_TX_CM.dds",
					"Skins\\Skin07\\annie_frankenstein.skl",
					"Skins\\Skin07\\annie_frankenstein.skn"
				},
                Image = LoLPath + imgPath + "Annie_7.jpg",
                Background = LoLPath + imgPath + "Annie_Splash_7.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("看到我的小熊了吗")
            {
                Files = 
				{
					"Skins\\Skin08\\AnnieLoadScreen_8.dds",
					"Skins\\Skin08\\Annie_Panda_CM.dds",
					"Skins\\Skin08\\Annie_Panda.skl",
					"Skins\\Skin08\\Annie_Panda.skn"
				},
                Image = LoLPath + imgPath + "Annie_8.jpg",
                Background = LoLPath + imgPath + "Annie_Splash_8.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Annies Bear", "AnnieTibbers");
            skin = new Skin("经典")
            {
                Files = 
				{
					"Skins\\Base\\AnnieTibbers_CM.dds",
					"Skins\\Base\\AnnieTibbers.skl",
					"Skins\\Base\\AnnieTibbers.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("哥特萝莉")
            {
                Files = 
				{
					"Skins\\Skin01\\annietibbers_goth_bear_TX_CM.dds",
					"Skins\\Skin01\\AnnieTibbers_Goth.skl",
					"Skins\\Skin01\\AnnieTibbers_Goth.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("小红帽")
            {
                Files = 
				{
					"Skins\\Skin02\\AnnieRR_Hood_tibbers_diffuse.dds",
					"Skins\\Skin02\\AnnieTibbers.skl",
					"Skins\\Skin02\\AnnieTibbers.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("安妮梦游仙境")
            {
                Files = 
				{
					"Skins\\Skin03\\AnnieTibbers_Wonderland_TX_CM.dds",
					"Skins\\Skin03\\AnnieTibbers_Wonderland.skl",
					"Skins\\Skin03\\AnnieTibbers_Wonderland.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("舞会公主")
            {
                Files = 
				{
					"Skins\\Skin04\\AnnieTibbers_Prom_TX_CM.dds",
					"Skins\\Skin04\\AnnieTibbers_Prom.skl",
					"Skins\\Skin04\\AnnieTibbers_Prom.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("冰霜烈焰")
            {
                Files = 
				{
					"Skins\\Skin05\\AnnieTibbers_FrostFire_TX_CM.dds",
					"Skins\\Skin05\\AnnieTibbers_FrostFire.skl",
					"Skins\\Skin05\\AnnieTibbers_FrostFire.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("安伯斯与提妮")
            {
                Files = 
				{
					"Skins\\Skin06\\AnnieTibbers_Reverse_TX_CM.dds",
					"Skins\\Skin06\\AnnieTibbers_Reverse.skl",
					"Skins\\Skin06\\AnnieTibbers_Reverse.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("科学怪熊的新娘")
            {
                Files = 
				{
					"Skins\\Skin07\\annie_tibbers_PET_frankenstein_TX_CM.dds",
					"Skins\\Skin07\\tibbers_PET_frankenstein.skl",
					"Skins\\Skin07\\tibbers_PET_frankenstein.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("你看到我的小熊了吗？")
            {
                Files = 
				{
					"Skins\\Skin07\\Tibbers_Panda_CM.dds",
					"Skins\\Skin07\\AnnieTibbers_Panda.skl",
					"Skins\\Skin07\\AnnieTibbers_Panda.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("Annies_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"AnnieBasicAttack_tar.troybin",
					"AnnieBasicAttack2_mis.troybin",
					"bearfire.dds",
					"color-bluehit.dds",
					"color-fireballtrail.dds",
					"color-flame.dds",
					"color-addflame.dds",
					"color-reckoning.dds",
					"color-billow.dds",
					"color-firemissile.dds",
					"color-incinerate.dds",
					"color-incineratedark.dds",
					"color-sparks.dds",
					"color-rock.dds",
					"color-firenova.dds",
					"BlueFlame.dds",
					"corona.dds",
					"Disintegrate02.dds",
					"DisintegrateFire.dds",
					"Disintegrate_hit.troybin",
					"DisintegrateHit_tar.troybin",
					"disintegrate-light.dds",
					"firebillow.dds",
					"firebillow32.dds",
					"FireHit.dds",
					"infernalguardian_tar.troybin",
					"Incinerate_buf.troybin",
					"fire_ball.dds",
					"flames03.dds",
					"rayfire.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("哥特萝莉");
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("小红帽");
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("安妮梦游仙境");
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("舞会公主");
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("冰霜烈焰")
            {
                Files = 
				{
					"AnnieBasicAttack_tar_frost.troybin",
					"AnnieBasicAttack2_mis.troybin",
					"flames03_frost.dds",
					"color-bluehit_frost.dds",
					"color-fireballtrail_frost.dds",
					"color-blueflame.dds",
					"color-blueflame.dds",
					"color-blueflame.dds",
					"color-blueflame.dds",
					"color-blueflame.dds",
					"color-blueflame.dds",
					"color-blueflame.dds",
					"color-blueflame.dds",
					"icerock01.dds",
					"color-bluehit_frost.dds",
					"BlueFlame_frost.dds",
					"corona_frost.dds",
					"Disintegrate02_frost.dds",
					"DisintegrateFrostAnnie.dds",
					"Disintegrate_hit_frost.troybin",
					"DisintegrateHit_tar_frost.troybin",
					"disintegrate-light_frost.dds",
					"annie_freljord_firebillow.dds",
					"annie_freljord_firebillow.dds",
					"FireHit_frost.dds",
					"infernalguardian_tar_frost.troybin",
					"Incinerate_buf_frost.troybin",
					"rayfire2_frost.dds",
					"flames03_frost.dds",
					"rayfire2_frost.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("安伯斯与提妮");
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("科学怪熊的新娘");
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("你看到我的小熊了吗？");
            champion.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("A-艾希·寒冰射手", "Ashe")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"AsheLoadScreen.dds",
					"ashe_base_2011_TX_CM.dds",
					"Ashe.skl",
					"Ashe.skn",
					"Animations\\ashe_run.anm",
					"Animations\\ashe_dance.anm"
				},
                Image = LoLPath + imgPath + "Ashe_0.jpg",
                Background = LoLPath + imgPath + "Ashe_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("极地女神")
            {
                Files = 
				{
					"AsheLoadScreen_1.dds",
					"ashe_freljord_2012_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Ashe_1.jpg",
                Background = LoLPath + imgPath + "Ashe_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("丛林侠盗")
            {
                Files = 
				{
					"AsheLoadScreen_2.dds",
					"ashe_sherwoodforest_2012_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Ashe_2.jpg",
                Background = LoLPath + imgPath + "Ashe_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("暗夜精灵")
            {
                Files = 
				{
					"AsheLoadScreen_3.dds",
					"ashe_woadleader_2012_TX_CM.dds",
					"Ashe_Woadleader.skl",
					"Ashe_Woadleader.skn"
				},
                Image = LoLPath + imgPath + "Ashe_3.jpg",
                Background = LoLPath + imgPath + "Ashe_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("女皇")
            {
                Files = 
				{
					"AsheLoadScreen_4.dds",
					"ashe_queen_2012_TX_CM.dds",
					"Ashe_queen.skl",
					"Ashe_queen.skn",
					"Animations\\Ashe_queen_run.anm"
				},
                Image = LoLPath + imgPath + "Ashe_4.jpg",
                Background = LoLPath + imgPath + "Ashe_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("紫晶射手")
            {
                Files = 
				{
					"AsheLoadScreen_5.dds",
					"ashe_crystal_TX_CM.dds",
					"Ashe_Crystal.skl",
					"Ashe_Crystal.skn",
					"Animations\\ashe_run.anm",
					"Animations\\ashe_crystal_dance.anm"
				},
                Image = LoLPath + imgPath + "Ashe_5.jpg",
                Background = LoLPath + imgPath + "Ashe_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("B-布里茨·蒸汽机器人", "Blitzcrank")
            {
                New = true
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"BlitzcrankLoadScreen.dds",
					"steamGolem.dds",
					"blitzcrank.skl",
					"blitzcrank.skn",
					"BaseSteamgolem.manifest",
					"Animations\\blitzcrank_dance.anm",
					"Animations\\blitzcrank_attack1.anm",
					"Animations\\blitzcrank_attack2.anm",
					"Animations\\blitzcrank_attack3.anm",
					"Animations\\blitzcrank_death.anm",
					"Animations\\blitzcrank_idle1.anm",
					"Animations\\blitzcrank_idle2.anm",
					"Animations\\blitzcrank_idle3.anm",
					"Animations\\blitzcrank_laugh.anm",
					"Animations\\blitzcrank_run.anm",
					"Animations\\blitzcrank_spell1.anm",
					"Animations\\blitzcrank_spell2.anm",
					"Animations\\blitzcrank_taunt.anm",
					"Animations\\blitzcrank_channel.anm",
					"Animations\\blitzcrank_channel_windup.anm"
				},
                Image = LoLPath + imgPath + "Blitzcrank_0.jpg",
                Background = LoLPath + imgPath + "Blitzcrank_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("铁锈斑斑")
            {
                Files = 
				{
					"BlitzcrankLoadScreen_1.dds",
					"Blitzcrank_Rusty_TX_CM.dds",
					"blitzcrank.skl",
					"blitzcrank.skn",
					"RustySteamgolem.manifest"
				},
                Image = LoLPath + imgPath + "Blitzcrank_1.jpg",
                Background = LoLPath + imgPath + "Blitzcrank_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("钢铁之门")
            {
                Files = 
				{
					"BlitzcrankLoadScreen_2.dds",
					"blitzcrank_soccer_TX_CM.dds",
					"Blitzcrank_Soccer.skl",
					"Blitzcrank_Soccer.skn",
					"SoccerSteamgolem.manifest"
				},
                Image = LoLPath + imgPath + "Blitzcrank_2.jpg",
                Background = LoLPath + imgPath + "Blitzcrank_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("擂台皇帝")
            {
                Files = 
				{
					"BlitzcrankLoadScreen_3.dds",
					"blitzcrank_boxer_TX_CM.dds",
					"blitzcrank_boxer.skl",
					"blitzcrank_boxer.skn",
					"BoxerSteamgolem.manifest",
					"Animations\\blitzcrank_boxer_dance.anm"
				},
                Image = LoLPath + imgPath + "Blitzcrank_3.jpg",
                Background = LoLPath + imgPath + "Blitzcrank_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("陆地王者4WD")
            {
                Files = 
				{
					"BlitzcrankLoadScreen_4.dds",
					"blitzcrank_custom_TX_CM.dds",
					"blitzcrank_custom.skl",
					"blitzcrank_custom.skn",
					"PiltoverCustomsBlitz.manifest",
					"Animations\\blitzcrank_custom_dance.anm",
					"Animations\\blitzcrank_custom_attack1.anm",
					"Animations\\blitzcrank_custom_attack2.anm",
					"Animations\\blitzcrank_custom_attack3.anm",
					"Animations\\blitzcrank_custom_death.anm",
					"Animations\\blitzcrank_custom_idle1.anm",
					"Animations\\blitzcrank_custom_idle2.anm",
					"Animations\\blitzcrank_custom_idle3.anm",
					"Animations\\blitzcrank_custom_laugh.anm",
					"Animations\\blitzcrank_custom_run.anm",
					"Animations\\blitzcrank_custom_spell1.anm",
					"Animations\\blitzcrank_custom_spell2.anm",
					"Animations\\blitzcrank_custom_taunt.anm",
					"Animations\\blitzcrank_custom_channel.anm",
					"Animations\\blitzcrank_custom_channel_windup.anm"
				},
                Image = LoLPath + imgPath + "Blitzcrank_4.jpg",
                Background = LoLPath + imgPath + "Blitzcrank_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("戴一个表")
            {
                Files = 
				{
					"BlitzcrankLoadScreen_5.dds",
					"blitzcrank_incognito_TX_CM.dds",
					"blitzcrank_incognito.skl",
					"blitzcrank_incognito.skn",
					"IncognitoBlitz.manifest",
					"Animations\\blitzcrank_dance.anm",
					"Animations\\blitzcrank_attack1.anm",
					"Animations\\blitzcrank_incognito_attack2.anm",
					"Animations\\blitzcrank_attack3.anm",
					"Animations\\blitzcrank_incognito_death.anm",
					"Animations\\blitzcrank_idle1.anm",
					"Animations\\blitzcrank_idle2.anm",
					"Animations\\blitzcrank_idle3.anm",
					"Animations\\blitzcrank_incognito_laugh.anm",
					"Animations\\blitzcrank_run.anm",
					"Animations\\blitzcrank_spell1.anm",
					"Animations\\blitzcrank_spell2.anm",
					"Animations\\blitzcrank_incognito_taunt.anm",
					"Animations\\blitzcrank_channel.anm",
					"Animations\\blitzcrank_incognito_channel_windup.anm"
				},
                Image = LoLPath + imgPath + "Blitzcrank_5.jpg",
                Background = LoLPath + imgPath + "Blitzcrank_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("I布利兹")
            {
                Files = 
				{
					"BlitzcrankLoadScreen_6.dds",
					"blitzcrank_i_TX_CM.dds",
					"blitzcrank_i.skl",
					"blitzcrank_i.skn",
					"iBlitz.manifest",
					"Animations\\blitzcrank_dance.anm",
					"Animations\\blitzcrank_attack1.anm",
					"Animations\\blitzcrank_incognito_attack2.anm",
					"Animations\\blitzcrank_attack3.anm",
					"Animations\\blitzcrank_incognito_death.anm",
					"Animations\\blitzcrank_idle1.anm",
					"Animations\\blitzcrank_idle2.anm",
					"Animations\\blitzcrank_idle3.anm",
					"Animations\\blitzcrank_incognito_laugh.anm",
					"Animations\\blitzcrank_run.anm",
					"Animations\\blitzcrank_spell1.anm",
					"Animations\\blitzcrank_spell2.anm",
					"Animations\\blitzcrank_incognito_taunt.anm",
					"Animations\\blitzcrank_channel.anm",
					"Animations\\blitzcrank_incognito_channel_windup.anm"
				},
                Image = LoLPath + imgPath + "Blitzcrank_6.jpg",
                Background = LoLPath + imgPath + "Blitzcrank_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Blitzcrank_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"steamgolem_base_fist.dds",
					"golemfist.sco",
					"SteamGolem_idle_left.troybin",
					"SteamGolem_Piltover_Overdrive.troybin",
					"SteamGolem_Piltover_Overdrive_Tires.troybin"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("铁锈斑斑")
            {
                Files = 
				{
					"steamgolem_rusty_fist.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("钢铁之门")
            {
                Files = 
				{
					"steamgolem_soccer_fist.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("擂台皇帝")
            {
                Files = 
				{
					"steamgolem_boxer_fist.dds",
					"golemglove.sco"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("陆地王者4WD")
            {
                Files = 
				{
					"piltover_customs_blitzcrank_TX_CM_v04.dds",
					"blitzcrank_custom_fist.sco",
					"SteamGolem_idle_Piltover.troybin",
					"SteamGolem_Piltover_Overdrive.troybin",
					"SteamGolem_Piltover_Overdrive_Tires.troybin"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("戴一个表")
            {
                Files = 
				{
					"blitzcrank_incognito_TX_CM.dds",
					"blitz_incog_fist.sco"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("I布利兹")
            {
                Files = 
				{
					"blitzcrank_i_TX_CM_red.dds",
					"Blitzcrank_iCrank_Chest.sco"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("B-布兰德·复仇焰魂", "Brand")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"BrandLoadScreen.dds",
					"brand_base_TX_CM.dds",
					"Brand.skl",
					"Brand.skn",
					"BrandBase.manifest",
					"animations\\Brand_attack1.anm",
					"animations\\Brand_attack2.anm",
					"animations\\Brand_spell1.anm",
					"animations\\Brand_spell2.anm",
					"animations\\Brand_spell3.anm",
					"animations\\Brand_spell4.anm"
				},
                Image = LoLPath + imgPath + "Brand_0.jpg",
                Background = LoLPath + imgPath + "Brand_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("末日余生")
            {
                Files = 
				{
					"BrandLoadScreen_1.dds",
					"brand_gasmask_TX_CM.dds",
					"brand_gasmask.skl",
					"brand_gasmask.skn",
					"GasmaskBrand.manifest"
				},
                Image = LoLPath + imgPath + "Brand_1.jpg",
                Background = LoLPath + imgPath + "Brand_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("V字仇杀者")
            {
                Files = 
				{
					"BrandLoadScreen_2.dds",
					"brand_vandals_TX_CM.dds",
					"Brand_Vandals.skl",
					"Brand_Vandals.skn",
					"VandalsBrand.manifest"
				},
                Image = LoLPath + imgPath + "Brand_2.jpg",
                Background = LoLPath + imgPath + "Brand_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冰晶之核⊙特效")
            {
                Files = 
				{
					"BrandLoadScreen_3.dds",
					"brand_frostfire_TX_CM.dds",
					"Brand_frostfire.skl",
					"Brand_frostfire.skn",
					"FrostFireBrand.manifest"
				},
                Image = LoLPath + imgPath + "Brand_3.jpg",
                Background = LoLPath + imgPath + "Brand_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("丧尸⊙特效")
            {
                Files = 
				{
					"BrandLoadScreen_4.dds",
					"brand_zombie_TX_CM.dds",
					"Brand_zombie.skl",
					"Brand_zombie.skn",
					"ZombieBrand.manifest",
					"animations\\Brand_zombie_attack1.anm",
					"animations\\Brand_zombie_attack2.anm",
					"animations\\Brand_zombie_spell1.anm",
					"animations\\Brand_zombie_spell2.anm",
					"animations\\Brand_zombie_spell3.anm",
					"animations\\Brand_zombie_spell4.anm"
				},
                Image = LoLPath + imgPath + "Brand_4.jpg",
                Background = LoLPath + imgPath + "Brand_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Brand_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"color-disintegratefire.dds",
					"fireloop_aura.dds",
					"disintegrate-light.dds",
					"fire-sphere32.dds",
					"color-incinerate.dds",
					"disintegrate-flash.dds",
					"FireHit.dds",
					"firehoop.dds",
					"color-righteousfury.dds",
					"color-brandblaze.dds",
					"BlazeRing.dds",
					"flames03.dds",
					"BlueFlame.dds",
					"color-firefade.dds",
					"color-fireballtrail.dds",
					"firetrail.dds",
					"color-BrandTrail.dds",
					"fire_ball.dds",
					"color-addflame.dds",
					"BrandBasicAttack_tar.troybin",
					"BrandBlaze_tar.troybin",
					"BrandConflagration_buf.troybin",
					"BrandConflagration_tar.troybin",
					"BrandCritAttack_tar.troybin",
					"BrandDeath.troybin",
					"BrandPOF_charge.troybin",
					"BrandPOF_tar.troybin",
					"BrandFireMark.troybin"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("末日余生");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("V字仇杀者");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("冰晶之核")
            {
                Files = 
				{
					"color-fireballtrail_frostBrand.dds",
					"fireloop_aura_BrandFrost.dds",
					"disintegrate-light_frost.dds",
					"icerock02.dds",
					"color-frostsmoke32D.dds",
					"disintegrate-light_frost.dds",
					"FireHit_frost.dds",
					"firehoop_frost.dds",
					"color-fireballtrail_frost.dds",
					"color-brandblaze_Frost.dds",
					"BlazeRingFrost.dds",
					"flames03_frost.dds",
					"BlueFlame_frost.dds",
					"color-firefade_frost.dds",
					"color-fireballtrail_brandfrost.dds",
					"firetrail_frost.dds",
					"color-fireballtrail_brandfrost.dds",
					"icerock02.dds",
					"color-blueflame.dds",
					"BrandBasicAttack_Frost_tar.troybin",
					"BrandBlazeFrost_tar.troybin",
					"BrandConflagration_buf_frost.troybin",
					"BrandConflagration_tar_frost.troybin",
					"BrandCritAttack_Frost_tar.troybin",
					"BrandDeath.troybin",
					"BrandPOF_Frost_charge.troybin",
					"BrandPOF_Frost_tar.troybin",
					"BrandFireMark_Frost.troybin"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("丧尸")
            {
                Files = 
				{
					"color-fireballtrail_brand_zombie.dds",
					"fireloop_aura.dds",
					"Brand_Zombie_glow.dds",
					"color-gloop_splat.dds",
					"color-gloop_splat.dds",
					"Brand_Zombie_glow.dds",
					"rayfire2_zombie.dds",
					"Brand_Zombie_headfiretrail.dds",
					"color-righteousfury.dds",
					"blazeringzombie.dds",
					"blazeringzombie.dds",
					"flames03.dds",
					"color-brand_zombie_flames.dds",
					"firehoop_zombie.dds",
					"color-fireballtrail_brand_zombie.dds",
					"Brand_Zombie_headfiretrail.dds",
					"color-fireballtrail_brand_zombie.dds",
					"Brand_Zombie_headfiretrail.dds",
					"color-greenflame.dds",
					"BrandBasicAttack_Zombie_tar.troybin",
					"BrandBlazeZombie_tar.troybin",
					"BrandConflagration_buf_Zombie.troybin",
					"BrandConflagration_tar_Zombie.troybin",
					"BrandCritAttack_Zombie_tar.troybin",
					"BrandDeath_Zombie.troybin",
					"BrandPOF_Zombie_charge.troybin",
					"BrandPOF_Zombie_tar.troybin",
					"BrandFireMark_Zombie.troybin"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("C-凯特琳·皮城女警", "Caitlyn")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"CaitlynLoadScreen.dds",
					"caitlyn_base_TX_CM_v01.dds",
					"Caitlyn.skl",
					"Caitlyn.skn",
					"Animations\\Caitlyn_Run.anm",
					"Animations\\Caitlyn_Idle2.anm",
					"Animations\\Caitlyn_spell4.anm"
				},
                Image = LoLPath + imgPath + "Caitlyn_0.jpg",
                Background = LoLPath + imgPath + "Caitlyn_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("抵抗军天使")
            {
                Files = 
				{
					"CaitlynLoadScreen_1.dds",
					"caitlyn_military_TX_CM.dds",
					"Caitlyn_military.skl",
					"Caitlyn_military.skn"
				},
                Image = LoLPath + imgPath + "Caitlyn_1.jpg",
                Background = LoLPath + imgPath + "Caitlyn_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("荒野治安官")
            {
                Files = 
				{
					"CaitlynLoadScreen_2.dds",
					"caitlyn_sheriff_TX_CM.dds",
					"Caitlyn_sheriff.skl",
					"Caitlyn_sheriff.skn"
				},
                Image = LoLPath + imgPath + "Caitlyn_2.jpg",
                Background = LoLPath + imgPath + "Caitlyn_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("古墓丽影")
            {
                Files = 
				{
					"CaitlynLoadScreen_3.dds",
					"caitlyn_safari_TX_CM.dds",
					"Caitlyn_safari.skl",
					"Caitlyn_safari.skn"
				},
                Image = LoLPath + imgPath + "Caitlyn_3.jpg",
                Background = LoLPath + imgPath + "Caitlyn_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冰原狙击")
            {
                Files = 
				{
					"CaitlynLoadScreen_4.dds",
					"caitlyn_northernfront_TX_CM.dds",
					"Caitlyn_northernfront.skl",
					"Caitlyn_northernfront.skn"
				},
                Image = LoLPath + imgPath + "Caitlyn_4.jpg",
                Background = LoLPath + imgPath + "Caitlyn_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("女警狙击")
            {
                Files = 
				{
					"CaitlynLoadScreen_5.dds",
					"caitlyn_cop_TX_CM.dds",
					"Caitlyn_cop.skl",
					"Caitlyn_cop.skn",
					"Animations\\Caitlyn_cop_Run.anm",
					"Animations\\Caitlyn_cop_Idle2.anm",
					"Animations\\Caitlyn_cop_spell4.anm"
				},
                Image = LoLPath + imgPath + "Caitlyn_5.jpg",
                Background = LoLPath + imgPath + "Caitlyn_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("C-卡西奥佩娅·魔蛇之拥", "Cassiopeia")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"cassiopeiaLoadScreen.dds",
					"cassiopeia_base_TX_CM.dds",
					"Cassiopeia.skl",
					"Cassiopeia.skn"
				},
                Image = LoLPath + imgPath + "Cassiopeia_0.jpg",
                Background = LoLPath + imgPath + "Cassiopeia_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("荒漠之咬")
            {
                Files = 
				{
					"cassiopeiaLoadScreen_1.dds",
					"cassiopeia_rattlesnake_TX_CM.dds",
					"Cassiopeia_rattlesnake.skl",
					"Cassiopeia_rattlesnake.skn"
				},
                Image = LoLPath + imgPath + "Cassiopeia_1.jpg",
                Background = LoLPath + imgPath + "Cassiopeia_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("深海妖姬")
            {
                Files = 
				{
					"cassiopeiaLoadScreen_2.dds",
					"cassiopeia_seasnake_TX_CM.dds",
					"Cassiopeia_seasnake.skl",
					"Cassiopeia_seasnake.skn"
				},
                Image = LoLPath + imgPath + "Cassiopeia_2.jpg",
                Background = LoLPath + imgPath + "Cassiopeia_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("蛇发女妖")
            {
                Files = 
				{
					"cassiopeiaLoadScreen_3.dds",
					"cassiopeia_greek_TX_CM.dds",
					"Cassiopeia_greek.skl",
					"Cassiopeia_greek.skn"
				},
                Image = LoLPath + imgPath + "Cassiopeia_3.jpg",
                Background = LoLPath + imgPath + "Cassiopeia_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("碧玉之牙")
            {
                Files = 
				{
					"cassiopeiaLoadScreen_4.dds",
					"cassiopeia_lunarrevel_TX_CM.dds",
					"Cassiopeia_LunarRevel.skl",
					"Cassiopeia_LunarRevel.skn"
				},
                Image = LoLPath + imgPath + "Cassiopeia_4.jpg",
                Background = LoLPath + imgPath + "Cassiopeia_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("C-卡西奥佩娅·魔蛇之拥", "Cassiopeia_Death");
            skin = new Skin("经典")
            {
                Files = 
				{
					"cassiopeia_stoned_TX_CM.dds",
					"Cassiopeia_Death.skl",
					"Cassiopeia_Death.skn",
					"Animations\\Cassiopeia_Aftermath.anm",
					"Animations\\Cassiopeia_Death.anm",
					"Animations\\Cassiopeia_Idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("荒漠之咬")
            {
                Files = 
				{
					"cassiopeia_stoned_TX_CM.dds",
					"Cassiopeia_Death.skl",
					"Cassiopeia_Death.skn",
					"Animations\\Cassiopeia_Aftermath.anm",
					"Animations\\Cassiopeia_Death.anm",
					"Animations\\Cassiopeia_Idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("深海妖姬")
            {
                Files = 
				{
					"cassiopeia_stoned_TX_CM.dds",
					"Cassiopeia_Death.skl",
					"Cassiopeia_Death.skn",
					"Animations\\Cassiopeia_Aftermath.anm",
					"Animations\\Cassiopeia_Death.anm",
					"Animations\\Cassiopeia_Idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("蛇发女妖")
            {
                Files = 
				{
					"cassiopeia_stoned_TX_CM.dds",
					"Cassiopeia_Death.skl",
					"Cassiopeia_Death.skn",
					"Animations\\Cassiopeia_Aftermath.anm",
					"Animations\\Cassiopeia_Death.anm",
					"Animations\\Cassiopeia_Idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("碧玉之牙")
            {
                Files = 
				{
					"cassiopeia_death_lunar_TX_CM.dds",
					"Cassiopeia_Death_LunarRevel.skl",
					"Cassiopeia_Death_LunarRevel.skn",
					"Animations\\Cassiopeia_Aftermath.anm",
					"Animations\\Cassiopeia_Death.anm",
					"Animations\\Cassiopeia_Idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("C-科加斯·虚空恐惧", "Chogath")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"ChogathLoadScreen.dds",
					"GreenTerror.dds",
					"Chogath.skl",
					"Chogath.skn",
					"Animations\\chogath_death.anm",
					"Animations\\chogath_taunt.anm"
				},
                Image = LoLPath + imgPath + "Chogath_0.jpg",
                Background = LoLPath + imgPath + "Chogath_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("梦魇")
            {
                Files = 
				{
					"ChogathLoadScreen_1.dds",
					"GreenTerror_alt.dds"
				},
                Image = LoLPath + imgPath + "Chogath_1.jpg",
                Background = LoLPath + imgPath + "Chogath_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("绅士")
            {
                Files = 
				{
					"ChogathLoadScreen_2.dds",
					"Greenterror_Dandy.dds",
					"Chogath_Dandy.skl",
					"Chogath_Dandy.skn"
				},
                Image = LoLPath + imgPath + "Chogath_2.jpg",
                Background = LoLPath + imgPath + "Chogath_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("尼斯巨兽")
            {
                Files = 
				{
					"ChogathLoadScreen_3.dds",
					"chogath_abyss_TX_CM.dds",
					"Chogath_abyss.skl",
					"Chogath_abyss.skn"
				},
                Image = LoLPath + imgPath + "Chogath_3.jpg",
                Background = LoLPath + imgPath + "Chogath_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("侏罗纪化石")
            {
                Files = 
				{
					"ChogathLoadScreen_4.dds",
					"chogath_dinosaur_TX_CM.dds",
					"Chogath_dinosaur.skl",
					"Chogath_dinosaur.skn",
					"Animations\\chogath_dino_death.anm",
					"Animations\\chogath_dino_taunt.anm"
				},
                Image = LoLPath + imgPath + "Chogath_4.jpg",
                Background = LoLPath + imgPath + "Chogath_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("战地巨兽")
            {
                Files = 
				{
					"ChogathLoadScreen_5.dds",
					"chogath_dinosaur_TX_CM.dds",
					"chogath_battlecast.skl",
					"chogath_battlecast.skn",
					"Animations\\chogath_battlecast_Death.anm",
					"Animations\\chogath_battlecast_Taunt.anm"
				},
                Image = LoLPath + imgPath + "Chogath_5.jpg",
                Background = LoLPath + imgPath + "Chogath_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("C-库奇·英勇投弹手", "Corki")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"CorkiLoadScreen.dds",
					"corki.dds",
					"Corki.skl",
					"Corki.skn",
					"Animations\\corki_attack1.anm",
					"Animations\\corki_attack2.anm",
					"Animations\\corki_dance.anm",
					"Animations\\corki_death.anm",
					"Animations\\corki_idle1.anm",
					"Animations\\corki_idle2.anm",
					"Animations\\corki_idle3.anm",
					"Animations\\corki_laugh.anm",
					"Animations\\corki_run.anm",
					"Animations\\corki_spell1.anm",
					"Animations\\corki_spell2.anm",
					"Animations\\corki_spell3.anm",
					"Animations\\corki_spell4.anm",
					"Animations\\corki_taunt.anm",
					"Animations\\corki_urfrider_crit.anm",
					"Animations\\corki_urfrider_joke.anm",
					"Animations\\corki_urfrider_attack1_60fps.anm"
				},
                Image = LoLPath + imgPath + "Corki_0.jpg",
                Background = LoLPath + imgPath + "Corki_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("外星装甲")
            {
                Files = 
				{
					"CorkiLoadScreen_1.dds",
					"Corki_ufo_TX_CM.dds",
					"Corki_FlyingSaucer.skl",
					"Corki_FlyingSaucer.skn"
				},
                Image = LoLPath + imgPath + "Corki_1.jpg",
                Background = LoLPath + imgPath + "Corki_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("雪橇速滑")
            {
                Files = 
				{
					"CorkiLoadScreen_2.dds",
					"corki_bobsled.dds",
					"Corki_bobsled.skl",
					"Corki_bobsled.skn"
				},
                Image = LoLPath + imgPath + "Corki_2.jpg",
                Background = LoLPath + imgPath + "Corki_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("红色男爵")
            {
                Files = 
				{
					"CorkiLoadScreen_3.dds",
					"corki_RedBaron.dds",
					"corki_RedBaron.skl",
					"corki_RedBaron.skn"
				},
                Image = LoLPath + imgPath + "Corki_3.jpg",
                Background = LoLPath + imgPath + "Corki_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("急速前进")
            {
                Files = 
				{
					"CorkiLoadScreen_4.dds",
					"corki_hotrod_TX_CM.dds",
					"Corki_hotrod.skl",
					"Corki_hotrod.skn"
				},
                Image = LoLPath + imgPath + "Corki_4.jpg",
                Background = LoLPath + imgPath + "Corki_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("海牛骑手")
            {
                Files = 
				{
					"CorkiLoadScreen_5.dds",
					"corki_urfrider_TX_CM.dds",
					"Corki_urf.skl",
					"Corki_urf.skn",
					"Animations\\corki_urfrider_attack1_60fps.anm",
					"Animations\\corki_urfrider_attack2.anm",
					"Animations\\corki_urfrider_dance.anm",
					"Animations\\corki_urfrider_death.anm",
					"Animations\\corki_urfrider_idle1.anm",
					"Animations\\corki_urfrider_idle2.anm",
					"Animations\\corki_urfrider_idle3.anm",
					"Animations\\corki_urfrider_laugh.anm",
					"Animations\\corki_urfrider_run.anm",
					"Animations\\corki_urfrider_spellcast1.anm",
					"Animations\\corki_urfrider_spellcast2.anm",
					"Animations\\corki_urfrider_spellcast3.anm",
					"Animations\\corki_urfrider_spellcast4.anm",
					"Animations\\corki_urfrider_taunt.anm",
					"Animations\\corki_urfrider_crit.anm",
					"Animations\\corki_urfrider_joke.anm",
					"Animations\\corki_urfrider_attack1_60fps.anm"
				},
                Image = LoLPath + imgPath + "Corki_5.jpg",
                Background = LoLPath + imgPath + "Corki_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("神龙之翼")
            {
                Files = 
				{
					"CorkiLoadScreen_6.dds",
					"corki_fireworks_TX_CM.dds",
					"Corki_Fireworks.skl",
					"Corki_Fireworks.skn",
					"Animations\\corki_Fireworks_attack1_60fps.anm",
					"Animations\\corki_Fireworks_attack2.anm",
					"Animations\\corki_Fireworks_dance.anm",
					"Animations\\corki_Fireworks_death.anm",
					"Animations\\corki_Fireworks_idle1.anm",
					"Animations\\corki_Fireworks_idle2.anm",
					"Animations\\corki_Fireworks_idle3.anm",
					"Animations\\corki_Fireworks_laugh.anm",
					"Animations\\corki_Fireworks_run.anm",
					"Animations\\corki_Fireworks_spellcast1.anm",
					"Animations\\corki_Fireworks_spellcast2.anm",
					"Animations\\corki_Fireworks_spellcast3.anm",
					"Animations\\corki_Fireworks_spellcast4.anm",
					"Animations\\corki_Fireworks_taunt.anm",
					"Animations\\corki_Fireworks_crit.anm",
					"Animations\\corki_Fireworks_joke.anm",
					"Animations\\corki_Fireworks_attack1_60fps.anm"
				},
                Image = LoLPath + imgPath + "Corki_6.jpg",
                Background = LoLPath + imgPath + "Corki_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("D-德莱厄斯·诺克萨斯之手", "Darius")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"DariusLoadScreen.dds",
					"darius_base_TX_CM.dds",
					"Darius.skl",
					"Darius.skn"
				},
                Image = LoLPath + imgPath + "Darius_0.jpg",
                Background = LoLPath + imgPath + "Darius_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("铁血皇帝⊙特效")
            {
                Files = 
				{
					"DariusLoadScreen_1.dds",
					"darius_emperor_TX_CM.dds",
					"Darius_Emperor.skl",
					"Darius_Emperor.skn"
				},
                Image = LoLPath + imgPath + "Darius_1.jpg",
                Background = LoLPath + imgPath + "Darius_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("生化骑士")
            {
                Files = 
				{
					"DariusLoadScreen_2.dds",
					"darius_zaun_knight_TX_CM.dds",
					"Darius_ZaunKnight.skl",
					"Darius_ZaunKnight.skn"
				},
                Image = LoLPath + imgPath + "Darius_2.jpg",
                Background = LoLPath + imgPath + "Darius_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Darius_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("铁血皇帝");
            champion.Secondary.Skins.Add(skin);
            skin.Files.Add("darius_w_props_01_base");
            skin.Files.Add("darius_props_ult_self_splatter_base");
            skin.Files.Add("darius_props_ult_blood_spatter_06");
            skin = new Skin("生化骑士")
            {
                Files = 
				{
					"",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("D-戴安娜·皎月女神", "Diana")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"DianaLoadScreen.dds",
					"Diana_base_TX_CM.dds.dds",
					"Diana.skl",
					"Diana.skn"
				},
                Image = LoLPath + imgPath + "Diana_0.jpg",
                Background = LoLPath + imgPath + "Diana_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("暗黑女武神")
            {
                Files = 
				{
					"DianaLoadScreen_1.dds",
					"Diana_dark_valkyrie_TX_CM.dds",
					"diana_dark_valkyrie.skl",
					"diana_dark_valkyrie.skn"
				},
                Image = LoLPath + imgPath + "Diana_1.jpg",
                Background = LoLPath + imgPath + "Diana_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("D-蒙多医生·祖安狂人", "DrMundo")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"DrMundoLoadScreen.dds",
					"DrMundo.dds",
					"DrMundo.skl",
					"DrMundo.skn",
					"Animations\\DrMundo_Run.anm",
					"Animations\\DrMundo_Dance.anm",
					"Animations\\DrMundo_Idle1.anm",
					"Animations\\DrMundo_Idle2.anm",
					"Animations\\DrMundo_Idle3.anm",
					"Animations\\DrMundo_Laugh.anm"
				},
                Image = LoLPath + imgPath + "DrMundo_0.jpg",
                Background = LoLPath + imgPath + "DrMundo_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("战栗之毒")
            {
                Files = 
				{
					"DrMundoLoadScreen_1.dds",
					"ToxicDrMundo.dds"
				},
                Image = LoLPath + imgPath + "DrMundo_1.jpg",
                Background = LoLPath + imgPath + "DrMundo_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("健美教练")
            {
                Files = 
				{
					"DrMundoLoadScreen_2.dds",
					"DrMundoWeight.dds",
					"DrMundo_mundoverse.skl",
					"DrMundo_mundoverse.skn"
				},
                Image = LoLPath + imgPath + "DrMundo_2.jpg",
                Background = LoLPath + imgPath + "DrMundo_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("律政大亨⊙特效")
            {
                Files = 
				{
					"DrMundoLoadScreen_3.dds",
					"drmundo_corporate_TX_CM.dds",
					"drmundo_corporate.skl",
					"drmundo_corporate.skn",
					"Animations\\DrMundo_corporate_Run.anm",
					"Animations\\DrMundo_corporate_Dance.anm",
					"Animations\\DrMundo_corporate_Idle1.anm",
					"Animations\\DrMundo_corporate_Idle2.anm",
					"Animations\\DrMundo_corporate_Idle3.anm",
					"Animations\\DrMundo_corporate_Laugh.anm"
				},
                Image = LoLPath + imgPath + "DrMundo_3.jpg",
                Background = LoLPath + imgPath + "DrMundo_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("蒙多蒙多⊙特效")
            {
                Files = 
				{
					"DrMundoLoadScreen_4.dds",
					"drmundo_mundo_TX_CM.dds",
					"DrMundo_mundo.skl",
					"DrMundo_mundo.skn"
				},
                Image = LoLPath + imgPath + "DrMundo_4.jpg",
                Background = LoLPath + imgPath + "DrMundo_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("嗜血行刑⊙特效")
            {
                Files = 
				{
					"DrMundoLoadScreen_5.dds",
					"drMundo_executioner_TX_CM.dds",
					"DrMundo_executioner.skl",
					"DrMundo_executioner.skn"
				},
                Image = LoLPath + imgPath + "DrMundo_5.jpg",
                Background = LoLPath + imgPath + "DrMundo_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("战争血统⊙特效")
            {
                Files = 
				{
					"DrMundoLoadScreen_6.dds",
					"drMundo_orc_TX_CM.dds",
					"DrMundo_orc.skl",
					"DrMundo_orc.skn",
					"Animations\\drmundo_orc_run.anm",
					"Animations\\drmundo_orc_dance.anm",
					"Animations\\drmundo_orc_idle1.anm",
					"Animations\\drmundo_orc_idle2.anm",
					"Animations\\drmundo_orc_idle3.anm",
					"Animations\\drmundo_orc_laugh.anm"
				},
                Image = LoLPath + imgPath + "DrMundo_6.jpg",
                Background = LoLPath + imgPath + "DrMundo_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("DrMundo_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"cleaver.sco",
					"mundo_cleaver_01.dds",
					"mundo_cleaver_02.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("战栗之毒");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("健美教练");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("律政大亨")
            {
                Files = 
				{
					"mundobcase.sco",
					"drmundo_corporate_TX_CM.dds",
					"drmundo_corporate_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("蒙多蒙多")
            {
                Files = 
				{
					"mundo_mundo_cleaver_MD.sco",
					"drmundo_mundo_TX_CM.dds",
					"drmundo_mundo_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("嗜血行刑")
            {
                Files = 
				{
					"drmundo_weapon_executioner.sco",
					"drMundo_executioner_TX_CM2_512.dds",
					"drMundo_executioner_TX_CM2_512.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("战争血统")
            {
                Files = 
				{
					"mundo_orc_cleaver.sco",
					"drmundo_orc_tx_cm.dds",
					"drmundo_orc_tx_cm.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("D-德莱文·荣耀行刑官", "Draven")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"DravenLoadScreen.dds",
					"Draven_base_TX_CM.dds",
					"draven.skl",
					"draven.skn"
				},
                Image = LoLPath + imgPath + "Draven_0.jpg",
                Background = LoLPath + imgPath + "Draven_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("灵魂收割者")
            {
                Files = 
				{
					"DravenLoadScreen_1.dds",
					"Draven_soul_reaper_TX_CM.dds",
					"draven_soulreaper.skl",
					"draven_soulreaper.skn"
				},
                Image = LoLPath + imgPath + "Draven_1.jpg",
                Background = LoLPath + imgPath + "Draven_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Fiora_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"Draven_WeaponTrail.dds",
					"Draven_WeaponTrail.sco",
					"Draven_WeaponSheen.dds",
					"Draven_Weapon.sco",
					"Draven_weapon.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin.Files.Add("Draven_SoulReaper_WeaponTrail.dds");
            skin.Files.Add("Draven_SoulReaper_RTrail.dds");
            skin.Files.Add("Draven_SoulReaper_Full.sco");
            skin.Files.Add("Draven_SoulReaper.sco");
            skin.Files.Add("draven_soulreaper.dds");
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("E-伊莉丝·蜘蛛女皇", "Elise")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"EliseLoadScreen.dds",
					"Skins\\Base\\Elise_base_Proxy_TX_CM.dds",
					"Skins\\Base\\Elise.skl",
					"Skins\\Base\\Elise.skn"
				},
                Image = LoLPath + imgPath + "Elise_0.jpg",
                Background = LoLPath + imgPath + "Elise_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("死亡之花⊙特效")
            {
                Files = 
				{
					"EliseLoadScreen_1.dds",
					"Skins\\Skin01\\Elise_LotusFlower_TX_CM.dds",
					"Skins\\Skin01\\Elise_LotusFlower.skl",
					"Skins\\Skin01\\Elise_LotusFlower.skn"
				},
                Image = LoLPath + imgPath + "Elise_1.jpg",
                Background = LoLPath + imgPath + "Elise_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("EliseSpider", "EliseSpider");
            skin = new Skin("经典")
            {
                Files = 
				{
					"Skins\\Base\\EliseSpider_base_TX_CM.dds",
					"Skins\\Base\\Elise_spider.skl",
					"Skins\\Base\\Elise_spider.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("死亡之花")
            {
                Files = 
				{
					"Skins\\Base\\EliseSpider_LotusFlower_TX_CM.dds",
					"Skins\\Base\\EliseSpider_LotusFlower.skl",
					"Skins\\Base\\EliseSpider_LotusFlower.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("EliseSpiderling", "EliseSpiderling");
            skin = new Skin("经典")
            {
                Files = 
				{
					"Skins\\Base\\EliseSpiderling_base_TX_CM.dds",
					"Skins\\Base\\Elise_spider.skl",
					"Skins\\Base\\Elise_spider.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("死亡之花")
            {
                Files = 
				{
					"Skins\\Base\\eliseSpiderling_lotus_TX_CM.dds",
					"Skins\\Base\\EliseSpider_LotusFlower.skl",
					"Skins\\Base\\EliseSpider_LotusFlower.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("E-伊芙琳·寡妇制造者", "Evelynn")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"evelynnLoadScreen.dds",
					"RG_Evelynn_Clr.dds",
					"Evelynn.skl",
					"Evelynn.skn"
				},
                Image = LoLPath + imgPath + "Evelynn_0.jpg",
                Background = LoLPath + imgPath + "Evelynn_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("黑暗女王")
            {
                Files = 
				{
					"evelynnLoadScreen_1.dds",
					"Evelynn_Alt.dds"
				},
                Image = LoLPath + imgPath + "Evelynn_1.jpg",
                Background = LoLPath + imgPath + "Evelynn_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("假面女皇")
            {
                Files = 
				{
					"evelynnLoadScreen_2.dds",
					"Evelynn_Catsuit_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Evelynn_2.jpg",
                Background = LoLPath + imgPath + "Evelynn_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("探戈灵魂")
            {
                Files = 
				{
					"evelynnLoadScreen_3.dds",
					"evelynn_tango_TX_CM_v01.dds",
					"Evelynn_tango.skl",
					"Evelynn_tango.skn"
				},
                Image = LoLPath + imgPath + "Evelynn_3.jpg",
                Background = LoLPath + imgPath + "Evelynn_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("E-伊泽瑞尔·探险家", "Ezreal")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"EzrealLoadScreen.dds",
					"Ezreal_ProdigalExplorer.dds",
					"Ezreal.skl",
					"Ezreal.skn",
					"Ezreal.manifest"
				},
                Image = LoLPath + imgPath + "Ezreal_0.jpg",
                Background = LoLPath + imgPath + "Ezreal_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冒险精神")
            {
                Files = 
				{
					"EzrealLoadScreen_1.dds",
					"Ezreal_Nottingham.dds",
					"Ezreal.skl",
					"Ezreal.skn"
				},
                Image = LoLPath + imgPath + "Ezreal_1.jpg",
                Background = LoLPath + imgPath + "Ezreal_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("足球先生")
            {
                Files = 
				{
					"EzrealLoadScreen_2.dds",
					"Ezreal_Soccer_TX_CM.dds",
					"Ezreal_Soccer.skl",
					"Ezreal_Soccer.skn"
				},
                Image = LoLPath + imgPath + "Ezreal_2.jpg",
                Background = LoLPath + imgPath + "Ezreal_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冰川勇者")
            {
                Files = 
				{
					"EzrealLoadScreen_3.dds",
					"ezreal_whitehair_TX_CM.dds",
					"Ezreal.skl",
					"Ezreal.skn"
				},
                Image = LoLPath + imgPath + "Ezreal_3.jpg",
                Background = LoLPath + imgPath + "Ezreal_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("失落的世界")
            {
                Files = 
				{
					"EzrealLoadScreen_4.dds",
					"ezreal_explorer_TX_CM.dds",
					"Ezreal_explorer.skl",
					"Ezreal_explorer.skn"
				},
                Image = LoLPath + imgPath + "Ezreal_4.jpg",
                Background = LoLPath + imgPath + "Ezreal_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("未来战士")
            {
                Files = 
				{
					"EzrealLoadScreen_5.dds",
					"ezreal_cyber_TX_CM.dds",
					"Ezreal_cyber.skl",
					"Ezreal_cyber.skn",
					"CyberEzreal.manifest"
				},
                Image = LoLPath + imgPath + "Ezreal_5.jpg",
                Background = LoLPath + imgPath + "Ezreal_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("F-费德提克·末日使者", "FiddleSticks")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"fiddlesticksLoadScreen.dds",
					"Fiddlesticks_Clr.dds",
					"FiddleSticks.skl",
					"FiddleSticks.skn",
					"animations\\FiddleSticks_Attack1.anm",
					"animations\\FiddleSticks_Attack2.anm",
					"animations\\FiddleSticks_Attack3.anm",
					"animations\\fiddlesticks_channel.anm",
					"animations\\fiddlesticks_channel_windup.anm",
					"animations\\FiddleSticks_Dance.anm",
					"animations\\Fiddlesticks_death.anm",
					"animations\\FiddleSticks_Idle1.anm",
					"animations\\Fiddlesticks_idle2.anm",
					"animations\\FiddleSticks_Idle3.anm",
					"animations\\FiddleSticks_Idle4.anm",
					"animations\\FiddleSticks_Laugh.anm",
					"animations\\FiddleSticks_Run.anm",
					"animations\\fiddlesticks_spell1.anm",
					"animations\\Fiddlesticks_Spell2.anm",
					"animations\\fiddlesticks_spell2_loop.anm",
					"animations\\fiddlesticks_spell2_winddown.anm",
					"animations\\fiddlesticks_spell2_windup.anm",
					"animations\\fiddlesticks_spell3.anm",
					"animations\\Fiddlesticks_Taunt.anm"
				},
                Image = LoLPath + imgPath + "Fiddlesticks_0.jpg",
                Background = LoLPath + imgPath + "Fiddlesticks_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("幽魂")
            {
                Files = 
				{
					"fiddlesticksLoadScreen_1.dds",
					"FiddlesticksGhost.dds"
				},
                Image = LoLPath + imgPath + "Fiddlesticks_1.jpg",
                Background = LoLPath + imgPath + "Fiddlesticks_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("联合王国")
            {
                Files = 
				{
					"fiddlesticksLoadScreen_2.dds",
					"Fiddlesticks_british.dds"
				},
                Image = LoLPath + imgPath + "Fiddlesticks_2.jpg",
                Background = LoLPath + imgPath + "Fiddlesticks_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("荒野幽灵")
            {
                Files = 
				{
					"fiddlesticksLoadScreen_3.dds",
					"fiddlesticks_bandito_TX_CM.dds",
					"fiddlesticks_bandito.skl",
					"fiddlesticks_bandito.skn"
				},
                Image = LoLPath + imgPath + "Fiddlesticks_3.jpg",
                Background = LoLPath + imgPath + "Fiddlesticks_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("南瓜头")
            {
                Files = 
				{
					"fiddlesticksLoadScreen_4.dds",
					"fiddlesticks_halloween_TX_CM.dds",
					"fiddlesticks_halloween.skl",
					"fiddlesticks_halloween.skn"
				},
                Image = LoLPath + imgPath + "Fiddlesticks_4.jpg",
                Background = LoLPath + imgPath + "Fiddlesticks_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("铁钩船长")
            {
                Files = 
				{
					"fiddlesticksLoadScreen_5.dds",
					"fiddlesticks_pirate_TX_CM.dds",
					"fiddlesticks_pirate.skl",
					"fiddlesticks_pirate.skn"
				},
                Image = LoLPath + imgPath + "Fiddlesticks_5.jpg",
                Background = LoLPath + imgPath + "Fiddlesticks_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("惊悚派对⊙特效")
            {
                Files = 
				{
					"fiddlesticksLoadScreen_6.dds",
					"fiddlesticks_surpriseparty_TX_CM.dds",
					"fiddlesticks_surpriseparty.skl",
					"fiddlesticks_surpriseparty.skn",
					"animations\\fiddlesticks_surpriseparty_attack1.anm",
					"animations\\fiddlesticks_surpriseparty_attack2.anm",
					"animations\\fiddlesticks_surpriseparty_attack3.anm",
					"animations\\fiddlesticks_surpriseparty_channel.anm",
					"animations\\fiddlesticks_surpriseparty_channel_windup.anm",
					"animations\\fiddlesticks_surpriseparty_dance.anm",
					"animations\\fiddlesticks_surpriseparty_death.anm",
					"animations\\fiddlesticks_surpriseparty_idle1.anm",
					"animations\\fiddlesticks_surpriseparty_idle2.anm",
					"animations\\fiddlesticks_surpriseparty_idle2.anm",
					"animations\\fiddlesticks_surpriseparty_idle3.anm",
					"animations\\fiddlesticks_surpriseparty_laugh.anm",
					"animations\\fiddlesticks_surpriseparty_run.anm",
					"animations\\fiddlesticks_surpriseparty_spell1.anm",
					"animations\\fiddlesticks_surpriseparty_spell2.anm",
					"animations\\fiddlesticks_surpriseparty_spell2_loop.anm",
					"animations\\fiddlesticks_surpriseparty_spell2_winddown.anm",
					"animations\\fiddlesticks_surpriseparty_spell2_windup.anm",
					"animations\\fiddlesticks_surpriseparty_spell3.anm",
					"animations\\fiddlesticks_surpriseparty_taunt.anm"
				},
                Image = LoLPath + imgPath + "Fiddlesticks_6.jpg",
                Background = LoLPath + imgPath + "Fiddlesticks_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("糖果使者")
            {
                Files = 
				{
					"fiddlesticksLoadScreen_7.dds",
					"fiddlesticks_candycane_TX_CM.dds",
					"fiddlesticks_candycane.skl",
					"fiddlesticks_candycane.skn",
					"animations\\fiddlesticks_candycane_attack1.anm",
					"animations\\fiddlesticks_candycane_attack2.anm",
					"animations\\fiddlesticks_candycane_attack3.anm",
					"animations\\fiddlesticks_candycane_channel.anm",
					"animations\\fiddlesticks_candycane_channel_windup.anm",
					"animations\\fiddlesticks_candycane_dance.anm",
					"animations\\fiddlesticks_candycane_death.anm",
					"animations\\fiddlesticks_candycane_idle1.anm",
					"animations\\fiddlesticks_candycane_idle2.anm",
					"animations\\fiddlesticks_candycane_idle2.anm",
					"animations\\fiddlesticks_candycane_idle3.anm",
					"animations\\fiddlesticks_candycane_laugh.anm",
					"animations\\fiddlesticks_candycane_run.anm",
					"animations\\fiddlesticks_candycane_spell1.anm",
					"animations\\fiddlesticks_candycane_spell2.anm",
					"animations\\fiddlesticks_candycane_spell2_loop.anm",
					"animations\\fiddlesticks_candycane_spell2_winddown.anm",
					"animations\\fiddlesticks_candycane_spell2_windup.anm",
					"animations\\fiddlesticks_candycane_spell3.anm",
					"animations\\fiddlesticks_candycane_taunt.anm"
				},
                Image = LoLPath + imgPath + "Fiddlesticks_7.jpg",
                Background = LoLPath + imgPath + "Fiddlesticks_Splash_7.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Fiddlesticks_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"FiddleSticksBasicAttack01.dds",
					"Fiddlesticks_TerrorFace.dds",
					"LifeBeam.dds",
					"magicBall01_1.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("幽魂");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("联合王国");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("荒野幽灵");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("南瓜头");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("铁钩船长");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("惊悚派对")
            {
                Files = 
				{
					"SurpriseFids_pinwheel02.dds",
					"Fiddlesticks_PartyFace.dds",
					"magicBall01_1.dds",
					"LifeBeam.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("糖果使者");
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("F-菲奥娜·无双剑姬", "Fiora")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"FioraLoadScreen.dds",
					"fiora_base_TX_CM.dds",
					"Fiora.skl",
					"Fiora.skn",
					"Fiora.manifest"
				},
                Image = LoLPath + imgPath + "Fiora_0.jpg",
                Background = LoLPath + imgPath + "Fiora_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("皇家守卫")
            {
                Files = 
				{
					"FioraLoadScreen_1.dds",
					"fiora_musketeer_TX_CM.dds",
					"fiora_musketeer.skl",
					"fiora_musketeer.skn"
				},
                Image = LoLPath + imgPath + "Fiora_1.jpg",
                Background = LoLPath + imgPath + "Fiora_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("夜鸦")
            {
                Files = 
				{
					"FioraLoadScreen_2.dds",
					"fiora_zorro_TX_CM.dds",
					"fiora_zorro.skl",
					"fiora_zorro.skn"
				},
                Image = LoLPath + imgPath + "Fiora_2.jpg",
                Background = LoLPath + imgPath + "Fiora_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("女校长")
            {
                Files = 
				{
					"FioraLoadScreen_3.dds",
					"fiora_schoolteacher_TX_CM.dds",
					"fiora_schoolteacher.skl",
					"fiora_schoolteacher.skn",
					"FioraSchoolTeacher.manifest"
				},
                Image = LoLPath + imgPath + "Fiora_3.jpg",
                Background = LoLPath + imgPath + "Fiora_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Fiora_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"fiora_base.dds",
					"fiora_desat.dds",
					"fiora_weapon.sco",
					"Fiora_WeaponSheen.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("皇家守卫")
            {
                Files = 
				{
					"fiora_musketeer.dds",
					"fiora_musketeer_desat.dds",
					"Fiora_Musketeer.sco",
					"Fiora_WeaponSheen_musketeer.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("夜鸦")
            {
                Files = 
				{
					"fiora_zorro.dds",
					"fiora_zorro_desat.dds",
					"Fiora_Zorro.sco",
					"Fiora_WeaponSheen.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("女校长")
            {
                Files = 
				{
					"sword_glow_05.dds",
					"fiora_schoolteacher_TX_CM.dds",
					"FioraShield.sco",
					"Fiora_mesh_Weapontrail.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("F-菲兹·潮汐海灵", "Fizz")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"FizzLoadScreen.dds",
					"fizz_base_TX_CM.dds",
					"Fizz.skl",
					"Fizz.skn"
				},
                Image = LoLPath + imgPath + "Fizz_0.jpg",
                Background = LoLPath + imgPath + "Fizz_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("失落的大陆")
            {
                Files = 
				{
					"FizzLoadScreen_1.dds",
					"fizz_atlantean_TX_CM.dds",
					"Fizz_atlantean.skl",
					"Fizz_atlantean.skn"
				},
                Image = LoLPath + imgPath + "Fizz_1.jpg",
                Background = LoLPath + imgPath + "Fizz_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("苔原猎手")
            {
                Files = 
				{
					"FizzLoadScreen_2.dds",
					"fizz_arctic_TX_CM.dds",
					"Fizz_arctic.skl",
					"Fizz_arctic.skn"
				},
                Image = LoLPath + imgPath + "Fizz_2.jpg",
                Background = LoLPath + imgPath + "Fizz_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("海牛猎手")
            {
                Files = 
				{
					"FizzLoadScreen_3.dds",
					"fizz_fisherman_TX_CM.dds",
					"fizz_fisherman.skl",
					"fizz_fisherman.skn"
				},
                Image = LoLPath + imgPath + "Fizz_3.jpg",
                Background = LoLPath + imgPath + "Fizz_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("FizzBait", "FizzBait");
            skin = new Skin("经典")
            {
                Files = 
				{
					"fizzbait_TX_CM.dds",
					"FizzBait.skl",
					"FizzBait.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("失落的大陆");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("苔原猎手");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("海牛猎手");
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("FizzShark", "FizzShark");
            skin = new Skin("经典")
            {
                Files = 
				{
					"fizz_shark_base_TX_CM.dds",
					"FizzShark.skl",
					"FizzShark.skn",
					"Animations\\fizzshark_spell4.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("失落的大陆")
            {
                Files = 
				{
					"FizzShark_atlantean_TX_CM.dds",
					"FizzShark_atlantean.skl",
					"FizzShark_atlantean.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("苔原猎手")
            {
                Files = 
				{
					"FizzShark_arctic_TX_CM.dds",
					"FizzShark_arctic.skl",
					"FizzShark_arctic.skn",
					"Animations\\fizzshark_arctic_spell4.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("海牛猎手")
            {
                Files = 
				{
					"fizzshark_fisherman_TX_CM.dds",
					"fizzshark_fisherman.skl",
					"fizzshark_fisherman.skn",
					"Animations\\fizzshark_fisherman_spell4.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("G-加里奥·哨兵之殇", "Galio")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"GalioLoadScreen.dds",
					"galio_base_TX_CM.dds",
					"galio.skl",
					"galio.skn"
				},
                Image = LoLPath + imgPath + "Galio_0.jpg",
                Background = LoLPath + imgPath + "Galio_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("幽蓝梦魇")
            {
                Files = 
				{
					"GalioLoadScreen_1.dds",
					"galio_enchanted_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Galio_1.jpg",
                Background = LoLPath + imgPath + "Galio_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("机械迷城")
            {
                Files = 
				{
					"GalioLoadScreen_2.dds",
					"galio_hextech_TX_CM.dds",
					"galio_hextech.skl",
					"galio_hextech.skn"
				},
                Image = LoLPath + imgPath + "Galio_2.jpg",
                Background = LoLPath + imgPath + "Galio_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("战地之王")
            {
                Files = 
				{
					"GalioLoadScreen_3.dds",
					"galio_commando_TX_CM.dds",
					"galio_commando.skl",
					"galio_commando.skn"
				},
                Image = LoLPath + imgPath + "Galio_3.jpg",
                Background = LoLPath + imgPath + "Galio_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("地狱守门人")
            {
                Files = 
				{
					"GalioLoadScreen_4.dds",
					"galio_gatekeeper_TX_CM.dds",
					"galio_gatekeeper.skl",
					"galio_gatekeeper.skn"
				},
                Image = LoLPath + imgPath + "Galio_4.jpg",
                Background = LoLPath + imgPath + "Galio_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Galio_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"galio_armor_05.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("幽蓝梦魇")
            {
                Files = 
				{
					"galio_armor_enchanted_05.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("机械迷城")
            {
                Files = 
				{
					"galio_armor_hextech_05.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("战地之王")
            {
                Files = 
				{
					"galio_armor_gatekeeper_05.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("地狱守门人")
            {
                Files = 
				{
					"galio_armor_commando_05.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("G-普朗克·海洋之灾", "Gangplank")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"GangplankLoadScreen.dds",
					"gangplank_base_2011_TX_CM.dds",
					"Gangplank_2011.skl",
					"Gangplank_2011.skn",
					"Animations\\gangplank_death.anm",
					"Animations\\gangplank_idle1.anm",
					"Animations\\gangplank_key.anm",
					"Animations\\gangplank_run.anm",
					"Animations\\gangplank_spell1.anm",
					"Animations\\gangplank_taunt.anm"
				},
                Image = LoLPath + imgPath + "Gangplank_0.jpg",
                Background = LoLPath + imgPath + "Gangplank_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("幽灵船长")
            {
                Files = 
				{
					"GangplankLoadScreen_1.dds",
					"gangplank_ghost_2011_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Gangplank_1.jpg",
                Background = LoLPath + imgPath + "Gangplank_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("老兵")
            {
                Files = 
				{
					"GangplankLoadScreen_2.dds",
					"gangplank_minuteman_TX_CM.dds",
					"Gangplank_minuteman.skl",
					"Gangplank_minuteman.skn"
				},
                Image = LoLPath + imgPath + "Gangplank_2.jpg",
                Background = LoLPath + imgPath + "Gangplank_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("大力水手")
            {
                Files = 
				{
					"GangplankLoadScreen_3.dds",
					"gangplank_sailor_TX_CM.dds",
					"Gangplank_Sailor.skl",
					"Gangplank_Sailor.skn"
				},
                Image = LoLPath + imgPath + "Gangplank_3.jpg",
                Background = LoLPath + imgPath + "Gangplank_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("英勇玩具兵")
            {
                Files = 
				{
					"GangplankLoadScreen_4.dds",
					"gangplank_toysoldier_TX_CM.dds",
					"Gangplank_toysoldier.skl",
					"Gangplank_toysoldier.skn",
					"Animations\\gangplank_toysoldier_death.anm",
					"Animations\\gangplank_toysoldier_Idle1.anm",
					"Animations\\gangplank_toysoldier_key.anm",
					"Animations\\gangplank_toysoldier_run.anm",
					"Animations\\gangplank_toysoldier_Spell1.anm",
					"Animations\\gangplank_toysoldier_taunt.anm"
				},
                Image = LoLPath + imgPath + "Gangplank_4.jpg",
                Background = LoLPath + imgPath + "Gangplank_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("特种部队⊙特效")
            {
                Files = 
				{
					"GangplankLoadScreen_5.dds",
					"gangplank_special_forces_TX_CM.dds",
					"gangplank_special_forces.skl",
					"gangplank_special_forces.skn"
				},
                Image = LoLPath + imgPath + "Gangplank_5.jpg",
                Background = LoLPath + imgPath + "Gangplank_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Gangplank_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("幽灵船长")
            {
                Files = 
				{
					"",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("老兵")
            {
                Files = 
				{
					"",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("大力水手")
            {
                Files = 
				{
					"",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("英勇玩具兵")
            {
                Files = 
				{
					"",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("特种部队");
            skin.Files.Add("GangPlank_SpecialForces_R_Bomb.sco");
            skin.Files.Add("gangplank_specialforces_r_bomb.dds");
            skin.Files.Add("GangPlank_E_Orb.dds");
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("G-盖伦·德玛西亚之力", "Garen")
            {
                New = true
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"GarenLoadScreen.dds",
					"GarenOrthograph_texture_v4.dds",
					"Garen.skl",
					"Garen.skn",
					"Garen.manifest"
				},
                Image = LoLPath + imgPath + "Garen_0.jpg",
                Background = LoLPath + imgPath + "Garen_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("战神阿瑞斯")
            {
                Files = 
				{
					"GarenLoadScreen_1.dds",
					"Garen_RedGoldArmor_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Garen_1.jpg",
                Background = LoLPath + imgPath + "Garen_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("荒漠骑士")
            {
                Files = 
				{
					"GarenLoadScreen_2.dds",
					"Garen_DTrooper_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Garen_2.jpg",
                Background = LoLPath + imgPath + "Garen_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("铁甲雄心")
            {
                Files = 
				{
					"GarenLoadScreen_3.dds",
					"garen_commando_TX_CM.dds",
					"garen_commando.skl",
					"garen_commando.skn"
				},
                Image = LoLPath + imgPath + "Garen_3.jpg",
                Background = LoLPath + imgPath + "Garen_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("死亡骑士")
            {
                Files = 
				{
					"GarenLoadScreen_4.dds",
					"garen_dreadknight_TX_CM.dds",
					"Garen_dreadknight.skl",
					"Garen_dreadknight.skn"
				},
                Image = LoLPath + imgPath + "Garen_4.jpg",
                Background = LoLPath + imgPath + "Garen_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("孤高游侠")
            {
                Files = 
				{
					"GarenLoadScreen_5.dds",
					"garen_ranger_TX_CM.dds",
					"Garen_ranger.skl",
					"Garen_ranger.skn",
					"SteellegionGaren.manifest"
				},
                Image = LoLPath + imgPath + "Garen_5.jpg",
                Background = LoLPath + imgPath + "Garen_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("钢铁军团")
            {
                Files = 
				{
					"GarenLoadScreen_6.dds",
					"garen_steelLegion_TX_CM.dds",
					"garen_steellegion.skl",
					"garen_steellegion.skn",
					"SteellegionGaren.manifest"
				},
                Image = LoLPath + imgPath + "Garen_6.jpg",
                Background = LoLPath + imgPath + "Garen_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("G-古拉加斯·酒桶", "Gragas")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"GragasLoadScreen.dds",
					"gragas.dds",
					"Gragas.skl",
					"Gragas.skn",
					"Animations\\Gragas_spell1.anm",
					"Animations\\Gragas_spell2.anm",
					"Animations\\Gragas_spell2_windup.anm",
					"Animations\\Gragas_spell2_loop.anm",
					"Animations\\Gragas_spell2_winddown.anm",
					"Animations\\Gragas_spell4.anm",
					"Animations\\Gragas_Idle2.anm"
				},
                Image = LoLPath + imgPath + "Gragas_0.jpg",
                Background = LoLPath + imgPath + "Gragas_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("深潜蛙人")
            {
                Files = 
				{
					"GragasLoadScreen_1.dds",
					"gragas_scuba.dds",
					"gragas_scuba.skl",
					"gragas_scuba.skn"
				},
                Image = LoLPath + imgPath + "Gragas_1.jpg",
                Background = LoLPath + imgPath + "Gragas_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("乡村农夫")
            {
                Files = 
				{
					"GragasLoadScreen_2.dds",
					"Gragas_HillBilly_TX_CM.dds",
					"gragas_HillBilly.skl",
					"gragas_HillBilly.skn"
				},
                Image = LoLPath + imgPath + "Gragas_2.jpg",
                Background = LoLPath + imgPath + "Gragas_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("圣诞老人⊙特效")
            {
                Files = 
				{
					"GragasLoadScreen_3.dds",
					"gragas_santa_TX_CM.dds",
					"Gragas_santa.skl",
					"Gragas_santa.skn",
					"Animations\\Gragas_santa_spell1.anm",
					"Animations\\Gragas_santa_spell2.anm",
					"Animations\\Gragas_santa_spell2_windup.anm",
					"Animations\\Gragas_santa_spell2_loop.anm",
					"Animations\\Gragas_santa_spell2_winddown.anm",
					"Animations\\Gragas_santa_spell4.anm"
				},
                Image = LoLPath + imgPath + "Gragas_3.jpg",
                Background = LoLPath + imgPath + "Gragas_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("品酒大师⊙特效")
            {
                Files = 
				{
					"GragasLoadScreen_4.dds",
					"gragas_classy_TX_CM.dds",
					"Gragas_classy.skl",
					"Gragas_classy.skn",
					"Animations\\Gragas_spell1.anm",
					"Animations\\Gragas_spell2.anm",
					"Animations\\gragas_classy_spell2_windup.anm",
					"Animations\\gragas_classy_spell2_loop.anm",
					"Animations\\gragas_classy_spell2_winddown.anm",
					"Animations\\gragas_classy_spell4.anm",
					"Animations\\gragas_classy_idle2.anm"
				},
                Image = LoLPath + imgPath + "Gragas_4.jpg",
                Background = LoLPath + imgPath + "Gragas_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("飞车暴走族⊙特效")
            {
                Files = 
				{
					"GragasLoadScreen_5.dds",
					"gragas_vandals_TX_CM.dds",
					"gragas_vandals.skl",
					"gragas_vandals.skn",
					"Animations\\Gragas_spell1.anm",
					"Animations\\gragas_vandals_Spell2_KegHandle.anm",
					"Animations\\gragas_vandals_Spell2_KegHandle_windup.anm",
					"Animations\\gragas_vandals_Spell2_KegHandle_loop.anm",
					"Animations\\gragas_vandals_Spell2_KegHandle_winddown.anm",
					"Animations\\Gragas_spell4.anm",
					"Animations\\gragas_vandals_Idle2.anm"
				},
                Image = LoLPath + imgPath + "Gragas_5.jpg",
                Background = LoLPath + imgPath + "Gragas_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("美酒节特使⊙特效")
            {
                Files = 
				{
					"GragasLoadScreen_6.dds",
					"gragas_oktoberfest_TX_CM.dds",
					"gragas_oktoberfest.skl",
					"gragas_oktoberfest.skn"
				},
                Image = LoLPath + imgPath + "Gragas_6.jpg",
                Background = LoLPath + imgPath + "Gragas_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Gragas_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"gragascask.sco",
					"gragascask.dds",
					"barrelpiece.dds",
					"color-foamtrail.dds",
					"color-grog.dds",
					"color-grog-foamy.dds",
					"color-grogfroth.dds",
					"color-grogstrand.dds",
					"FlarePurple.dds",
					"barreljuice.dds",
					"color-winesplash.dds",
					"grogstrand.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("深潜蛙人");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("乡村农夫");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("圣诞老人")
            {
                Files = 
				{
					"giftbarrel.sco",
					"giftbarrel.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("品酒大师")
            {
                Files = 
				{
					"gragas_classy_bottle.sco",
					"gragas_classy_TX_CM.dds",
					"gragas_classy_champaign_glass_break.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("飞车暴走族")
            {
                Files = 
				{
					"gragascask.sco",
					"gragascask.dds",
					"gragas_vandal_barrelpiece.dds",
					"gragas_vandal_color-foamtrail.dds",
					"gragas_vandal_color-grog.dds",
					"gragas_vandal_color-grog-foamy.dds",
					"gragas_vandal_color-grogfroth.dds",
					"gragas_vandal_color-grogstrand.dds",
					"Flare-Rainbow_yellow_01.dds",
					"gragas_vandal_barreljuice.dds",
					"gragas-vandal_color-winesplash.dds",
					"gragas_vandal_grogstrand.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("美酒节特使")
            {
                Files = 
				{
					"gragas_oktoberfest_barrel_06.sco",
					"gragas_oktoberfest_props_01.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("G-格雷福斯·法外狂徒", "Graves")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"GravesLoadScreen.dds",
					"Graves.dds",
					"Graves.skl",
					"Graves.skn",
					"animations\\graves_attack1.anm",
					"animations\\graves_mafia_attack2.anm",
					"animations\\graves_channel.anm",
					"animations\\graves_channel_windup.anm",
					"animations\\graves_dance.anm",
					"animations\\graves_death.anm",
					"animations\\graves_idle1.anm",
					"animations\\graves_idle2.anm",
					"animations\\graves_idle3.anm",
					"animations\\graves_idle4.anm",
					"animations\\graves_joke.anm",
					"animations\\graves_laugh.anm",
					"animations\\graves_run.anm",
					"animations\\graves_mafia_spell1.anm",
					"animations\\graves_mafia_spell2.anm",
					"animations\\graves_mafia_spell3.anm",
					"animations\\graves_mafia_spell4.anm",
					"animations\\graves_taunt.anm"
				},
                Image = LoLPath + imgPath + "Graves_0.jpg",
                Background = LoLPath + imgPath + "Graves_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("怒火之炮")
            {
                Files = 
				{
					"GravesLoadScreen_1.dds",
					"graves_mercenary_TX_CM.dds",
					"Graves_mercenary.skl",
					"Graves_mercenary.skn",
					"animations\\graves_mercenary_run.anm"
				},
                Image = LoLPath + imgPath + "Graves_1.jpg",
                Background = LoLPath + imgPath + "Graves_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("杀出重围")
            {
                Files = 
				{
					"GravesLoadScreen_2.dds",
					"graves_breakout_TX_CM.dds",
					"Graves_breakout.skl",
					"Graves_breakout.skn"
				},
                Image = LoLPath + imgPath + "Graves_2.jpg",
                Background = LoLPath + imgPath + "Graves_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("黑手党")
            {
                Files = 
				{
					"GravesLoadScreen_3.dds",
					"graves_mafia_TX_CM.dds",
					"graves_mafia.skl",
					"graves_mafia.skn",
					"animations\\graves_mafia_attack1.anm",
					"animations\\graves_mafia_channel.anm",
					"animations\\graves_mafia_channel_windup.anm",
					"animations\\graves_mafia_dance.anm",
					"animations\\graves_mafia_death.anm",
					"animations\\graves_mafia_idle1.anm",
					"animations\\graves_mafia_idle2.anm",
					"animations\\graves_mafia_idle3.anm",
					"animations\\graves_mafia_idle4.anm",
					"animations\\graves_mafia_joke.anm",
					"animations\\graves_mafia_laugh.anm",
					"animations\\graves_mafia_run.anm",
					"animations\\graves_mafia_taunt.anm"
				},
                Image = LoLPath + imgPath + "Graves_3.jpg",
                Background = LoLPath + imgPath + "Graves_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("防爆士兵")
            {
                Files = 
				{
					"GravesLoadScreen_4.dds",
					"graves_riot_TX_CM.dds",
					"graves_riot.skl",
					"graves_riot.skn",
					"animations\\graves_mafia_attack1.anm",
					"animations\\graves_mafia_attack2.anm",
					"animations\\graves_mafia_channel.anm",
					"animations\\graves_mafia_channel_windup.anm",
					"animations\\graves_mafia_dance.anm",
					"animations\\graves_mafia_death.anm",
					"animations\\graves_mafia_idle1.anm",
					"animations\\graves_mafia_idle2.anm",
					"animations\\graves_mafia_idle3.anm",
					"animations\\graves_mafia_idle4.anm",
					"animations\\graves_mafia_joke.anm",
					"animations\\graves_mafia_laugh.anm",
					"animations\\graves_mafia_run.anm",
					"animations\\graves_mafia_taunt.anm",
					"animations\\graves_mafia_spell1.anm",
					"animations\\graves_mafia_spell2.anm",
					"animations\\graves_mafia_spell3.anm",
					"animations\\graves_mafia_spell4.anm"
				},
                Image = LoLPath + imgPath + "Graves_4.jpg",
                Background = LoLPath + imgPath + "Graves_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("H-黑默丁格·大发明家", "Heimerdinger")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"HeimerdingerLoadScreen.dds",
					"heimerdinger.dds",
					"Heimerdinger.skl",
					"Heimerdinger.skn"
				},
                Image = LoLPath + imgPath + "Heimerdinger_0.jpg",
                Background = LoLPath + imgPath + "Heimerdinger_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("第三类接触⊙特效")
            {
                Files = 
				{
					"HeimerdingerLoadScreen_1.dds",
					"Heimerdinger_Attacks_TX_CM.dds",
					"Heimerdinger_Attacks.skl",
					"Heimerdinger_Attacks.skn"
				},
                Image = LoLPath + imgPath + "Heimerdinger_1.jpg",
                Background = LoLPath + imgPath + "Heimerdinger_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("拆弹专家")
            {
                Files = 
				{
					"HeimerdingerLoadScreen_2.dds",
					"Heimerdinger_Failed_TX_CM.dds",
					"Heimerdinger_Failed.skl",
					"Heimerdinger_Failed.skn"
				},
                Image = LoLPath + imgPath + "Heimerdinger_2.jpg",
                Background = LoLPath + imgPath + "Heimerdinger_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("创意工坊⊙特效")
            {
                Files = 
				{
					"HeimerdingerLoadScreen_3.dds",
					"heimerdinger_mechanic_TX_CM.dds",
					"Heimerdinger_Mechanic.skl",
					"Heimerdinger_Mechanic.skn"
				},
                Image = LoLPath + imgPath + "Heimerdinger_3.jpg",
                Background = LoLPath + imgPath + "Heimerdinger_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("雪默丁格⊙特效")
            {
                Files = 
				{
					"HeimerdingerLoadScreen_4.dds",
					"heimerdinger_snowman_TX_CM.dds",
					"Heimerdinger_Snowman.skl",
					"Heimerdinger_Snowman.skn"
				},
                Image = LoLPath + imgPath + "Heimerdinger_4.jpg",
                Background = LoLPath + imgPath + "Heimerdinger_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("HeimerTYellow", "HeimerTYellow");
            skin = new Skin("经典")
            {
                Files = 
				{
					"H28GEvolutionTurret.dds",
					"HeimerdingerTurret.skl",
					"HeimerdingerTurret.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("第三类接触")
            {
                Files = 
				{
					"heimerdinger_turret_TX_CM_yellow.dds",
					"HeimerdingerTurret_alien.skl",
					"HeimerdingerTurret_alien.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("拆弹专家");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("创意工坊")
            {
                Files = 
				{
					"heimerdinger_turret_mechanic_PET_yellow_TX_CM.dds",
					"HeimerdingerTurret_mechanic.skl",
					"HeimerdingerTurret_mechanic.skn",
					"animations\\HeimerdingerTurret_mechanic_idle1.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("雪默丁格")
            {
                Files = 
				{
					"heimerdinger_turret_snow_PET_yellow_TX_CM.dds",
					"HeimerdingerTurret_Snow.skl",
					"HeimerdingerTurret_Snow.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("HeimerTGreen", "HeimerTGreen");
            skin = new Skin("经典")
            {
                Files = 
				{
					"heimerTurret_green.dds",
					"HeimerdingerTurret.skl",
					"HeimerdingerTurret.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("第三类接触")
            {
                Files = 
				{
					"heimerdinger_turret_TX_CM_green.dds",
					"HeimerdingerTurret_alien.skl",
					"HeimerdingerTurret_alien.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("拆弹专家");
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("创意工坊")
            {
                Files = 
				{
					"heimerdinger_turret_mechanic_PET_green_TX_CM.dds",
					"HeimerdingerTurret_mechanic.skl",
					"HeimerdingerTurret_mechanic.skn",
					"animations\\HeimerdingerTurret_mechanic_idle1.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("雪默丁格")
            {
                Files = 
				{
					"heimerdinger_turret_snow_PET_green_TX_CM.dds",
					"HeimerdingerTurret_Snow.skl",
					"HeimerdingerTurret_Snow.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary.Secondary = new Champion("HeimerTRed", "HeimerTRed");
            skin = new Skin("经典")
            {
                Files = 
				{
					"heimerTurret_red.dds",
					"HeimerdingerTurret.skl",
					"HeimerdingerTurret.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("第三类接触")
            {
                Files = 
				{
					"heimerdinger_turret_TX_CM_red.dds",
					"HeimerdingerTurret_alien.skl",
					"HeimerdingerTurret_alien.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("拆弹专家");
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("创意工坊")
            {
                Files = 
				{
					"heimerdinger_turret_mechanic_PET_red_TX_CM.dds",
					"HeimerdingerTurret_mechanic.skl",
					"HeimerdingerTurret_mechanic.skn",
					"animations\\HeimerdingerTurret_mechanic_idle1.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("雪默丁格")
            {
                Files = 
				{
					"heimerdinger_turret_snow_PET_red_TX_CM.dds",
					"HeimerdingerTurret_Snow.skl",
					"HeimerdingerTurret_Snow.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary.Secondary.Secondary = new Champion("HeimerTBlue", "HeimerTBlue");
            skin = new Skin("经典")
            {
                Files = 
				{
					"heimerTurret_ice.dds",
					"heimerTurret_red.dds",
					"HeimerdingerTurret.skl",
					"HeimerdingerTurret.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("第三类接触")
            {
                Files = 
				{
					"heimerdinger_turret_TX_CM_ice.dds",
					"heimerdinger_turret_TX_CM_red.dds",
					"HeimerdingerTurret_alien.skl",
					"HeimerdingerTurret_alien.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("拆弹专家");
            champion.Secondary.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("创意工坊")
            {
                Files = 
				{
					"heimerdinger_turret_mechanic_PET_blue_TX_CM.dds",
					"heimerdinger_turret_mechanic_PET_blue_TX_CM.dds",
					"HeimerdingerTurret_mechanic.skl",
					"HeimerdingerTurret_mechanic.skn",
					"animations\\HeimerdingerTurret_mechanic_idle1.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("雪默丁格")
            {
                Files = 
				{
					"heimerdinger_turret_snow_PET_blue_TX_CM.dds",
					"heimerdinger_turret_snow_PET_blue_TX_CM.dds",
					"HeimerdingerTurret_Snow.skl",
					"HeimerdingerTurret_Snow.skn",
					"animations\\heimerdingerturret_idle.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("H-赫卡里姆·战争之影", "Hecarim")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"HecarimLoadScreen.dds",
					"Hecarim_base_TX_CM.dds",
					"Hecarim.skl",
					"Hecarim.skn"
				},
                Image = LoLPath + imgPath + "Hecarim_0.jpg",
                Background = LoLPath + imgPath + "Hecarim_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("幽魂骑士")
            {
                Files = 
				{
					"HecarimLoadScreen_2.dds",
					"hecarim_shrouded_wraith_TX_CM.dds",
					"hecarim_shrouded_wraith.skl",
					"hecarim_shrouded_wraith.skn"
				},
                Image = LoLPath + imgPath + "Hecarim_2.jpg",
                Background = LoLPath + imgPath + "Hecarim_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("血色骑士")
            {
                Files = 
				{
					"HecarimLoadScreen_1.dds",
					"Hecarim_medieval_knight_TX_CM.dds",
					"Hecarim_medieval.skl",
					"Hecarim_medieval.skn"
				},
                Image = LoLPath + imgPath + "Hecarim_1.jpg",
                Background = LoLPath + imgPath + "Hecarim_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("无头骑士")
            {
                Files = 
				{
					"HecarimLoadScreen_3.dds",
					"hecarim_headless_TX_CM.dds",
					"Hecarim_headless.skl",
					"Hecarim_headless.skn"
				},
                Image = LoLPath + imgPath + "Hecarim_3.jpg",
                Background = LoLPath + imgPath + "Hecarim_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("I-艾瑞利亚·刀锋意志", "Irelia")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"IreliaLoadScreen.dds",
					"irelia_base_TX_CM.dds",
					"Irelia.skl",
					"Irelia.skn"
				},
                Image = LoLPath + imgPath + "Irelia_0.jpg",
                Background = LoLPath + imgPath + "Irelia_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("夜刃")
            {
                Files = 
				{
					"IreliaLoadScreen_1.dds",
					"irelia_shadow_TX_CM.dds",
					"Irelia_shadow.skl",
					"Irelia_shadow.skn"
				},
                Image = LoLPath + imgPath + "Irelia_1.jpg",
                Background = LoLPath + imgPath + "Irelia_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("自由之翼")
            {
                Files = 
				{
					"IreliaLoadScreen_2.dds",
					"irelia_pilot_TX_CM.dds",
					"Irelia_pilot.skl",
					"Irelia_pilot.skn"
				},
                Image = LoLPath + imgPath + "Irelia_2.jpg",
                Background = LoLPath + imgPath + "Irelia_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("夜行义贼")
            {
                Files = 
				{
					"IreliaLoadScreen_3.dds",
					"irelia_cyberblade_TX_CM.dds",
					"Irelia_cyberblade.skl",
					"Irelia_cyberblade.skn"
				},
                Image = LoLPath + imgPath + "Irelia_3.jpg",
                Background = LoLPath + imgPath + "Irelia_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("霜刃女王")
            {
                Files = 
				{
					"IreliaLoadScreen_4.dds",
					"irelia_frost_blade_TX_CM.dds",
					"irelia_frost_blade.skl",
					"irelia_frost_blade.skn"
				},
                Image = LoLPath + imgPath + "Irelia_4.jpg",
                Background = LoLPath + imgPath + "Irelia_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("刀锋意志_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"irelia_base_activate_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("夜刃")
            {
                Files = 
				{
					"irelia_shadow_activate_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("自由之翼")
            {
                Files = 
				{
					"irelia_pilot_activate_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("夜行义贼")
            {
                Files = 
				{
					"irelia_cyber_blade_TX_CM_W.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("霜刃女王")
            {
                Files = 
				{
					"irelia_frost_blade_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("J-迦娜·风暴之怒", "Janna")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"JannaLoadScreen.dds",
					"janna_base_TX_CM.dds",
					"Janna.skl",
					"Janna.skn"
				},
                Image = LoLPath + imgPath + "Janna_0.jpg",
                Background = LoLPath + imgPath + "Janna_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("暴风女神")
            {
                Files = 
				{
					"JannaLoadScreen_1.dds",
					"janna_lightning_TX_CM.dds",
					"Janna_lightning.skl",
					"Janna_lightning.skn"
				},
                Image = LoLPath + imgPath + "Janna_1.jpg",
                Background = LoLPath + imgPath + "Janna_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("海克斯科技")
            {
                Files = 
				{
					"JannaLoadScreen_2.dds",
					"janna_hextech_TX_CM.dds",
					"Janna_hextech.skl",
					"Janna_hextech.skn"
				},
                Image = LoLPath + imgPath + "Janna_2.jpg",
                Background = LoLPath + imgPath + "Janna_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("寒冰女皇")
            {
                Files = 
				{
					"JannaLoadScreen_3.dds",
					"janna_frostqueen_TX_CM.dds",
					"Janna_frostqueen.skl",
					"Janna_frostqueen.skn"
				},
                Image = LoLPath + imgPath + "Janna_3.jpg",
                Background = LoLPath + imgPath + "Janna_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("J-嘉文四世·德玛西亚皇子", "JarvanIV")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"JarvanIVLoadScreen.dds",
					"jarvanIV_base_TX_CM.dds",
					"JarvanIV.skl",
					"JarvanIV.skn",
					"Animations\\jarvanIV_run.anm",
					"JarvanIV.manifest"
				},
                Image = LoLPath + imgPath + "JarvanIV_0.jpg",
                Background = LoLPath + imgPath + "JarvanIV_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("孤单英豪")
            {
                Files = 
				{
					"JarvanIVLoadScreen_1.dds",
					"jarvan_commando_TX_CM.dds",
					"JarvanIV_commando.skl",
					"JarvanIV_commando.skn"
				},
                Image = LoLPath + imgPath + "JarvanIV_1.jpg",
                Background = LoLPath + imgPath + "JarvanIV_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("屠龙勇士")
            {
                Files = 
				{
					"JarvanIVLoadScreen_2.dds",
					"jarvan_monsterhunter_TX_CM.dds",
					"JarvanIV_monsterhunter.skl",
					"JarvanIV_monsterhunter.skn"
				},
                Image = LoLPath + imgPath + "JarvanIV_2.jpg",
                Background = LoLPath + imgPath + "JarvanIV_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("龙骑统帅")
            {
                Files = 
				{
					"JarvanIVLoadScreen_3.dds",
					"jarvanIV_dragoon_TX_CM.dds",
					"JarvanIV_dragoon.skl",
					"JarvanIV_dragoon.skn"
				},
                Image = LoLPath + imgPath + "JarvanIV_3.jpg",
                Background = LoLPath + imgPath + "JarvanIV_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("凯旋英雄")
            {
                Files = 
				{
					"JarvanIVLoadScreen_4.dds",
					"jarvanIV_warhero_TX_CM.dds",
					"JarvanIV_warhero.skl",
					"JarvanIV_warhero.skn",
					"Animations\\jarvanIV_warhero_run.anm"
				},
                Image = LoLPath + imgPath + "JarvanIV_4.jpg",
                Background = LoLPath + imgPath + "JarvanIV_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("吕布奉先")
            {
                Files = 
				{
					"JarvanIVLoadScreen_5.dds",
					"jarvanIV_lubu_TX_CM.dds",
					"jarvanIV_lubu.skl",
					"jarvanIV_lubu.skn",
					"Animations\\jarvanIV_run.anm",
					"LubuJarvanIV.manifest"
				},
                Image = LoLPath + imgPath + "JarvanIV_5.jpg",
                Background = LoLPath + imgPath + "JarvanIV_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("德玛西亚皇子Standard", "JarvanIVStandard");
            skin = new Skin("经典")
            {
                Files = 
				{
					"jarvanIV_base_TX_CM.dds",
					"JarvanIV_standard.skl",
					"JarvanIV_standard.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("孤单英豪")
            {
                Files = 
				{
					"jarvan_commando_TX_CM.dds",
					"JarvanIV_standard_commando.skl",
					"JarvanIV_standard_commando.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("屠龙勇士")
            {
                Files = 
				{
					"jarvan_monsterhunter_TX_CM.dds",
					"JarvanIV_standard_monsterhunter.skl",
					"JarvanIV_standard_monsterhunter.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("龙骑统帅")
            {
                Files = 
				{
					"jarvanIV_dragoon_TX_CM.dds",
					"JarvanIV_standard_dragoon.skl",
					"JarvanIV_standard_dragoon.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("凯旋英雄")
            {
                Files = 
				{
					"jarvanIV_base_TX_CM.dds",
					"JarvanIV_standard.skl",
					"JarvanIV_standard.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("吕布奉先")
            {
                Files = 
				{
					"jarvanIV_lubu_TX_CM.dds",
					"jarvanIV_standard_lubu.skl",
					"jarvanIV_standard_lubu.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("J-贾克斯·武器大师", "Jax")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"JaxLoadScreen.dds",
					"Armsmaster_Concept.dds",
					"Jax.skl",
					"Jax.skn",
					"animations\\jax_run.anm",
					"animations\\jax_taunt.anm",
					"animations\\jax_idle1.anm",
					"animations\\jax_death.anm",
					"animations\\jax_spell2.anm"
				},
                Image = LoLPath + imgPath + "Jax_0.jpg",
                Background = LoLPath + imgPath + "Jax_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冰球队员")
            {
                Files = 
				{
					"JaxLoadScreen_1.dds",
					"Jax_hockeystick_TX_CM.dds",
					"Jax_hockeystick.skl",
					"Jax_hockeystick.skn"
				},
                Image = LoLPath + imgPath + "Jax_1.jpg",
                Background = LoLPath + imgPath + "Jax_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("万夫莫开")
            {
                Files = 
				{
					"JaxLoadScreen_2.dds",
					"Jax_vandal_TX_CM.dds",
					"Jax_vandal.skl",
					"Jax_vandal.skn"
				},
                Image = LoLPath + imgPath + "Jax_2.jpg",
                Background = LoLPath + imgPath + "Jax_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("宗师级钓鱼训练师")
            {
                Files = 
				{
					"JaxLoadScreen_3.dds",
					"Jax_fisherman_TX_CM.dds",
					"Jax_fisherman.skl",
					"Jax_fisherman.skn"
				},
                Image = LoLPath + imgPath + "Jax_3.jpg",
                Background = LoLPath + imgPath + "Jax_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("卧虎藏龙")
            {
                Files = 
				{
					"JaxLoadScreen_4.dds",
					"jax_pax_TX_CM.dds",
					"jax_pax.skl",
					"jax_pax.skn",
					"animations\\Jax_PAX_Run.anm",
					"animations\\Jax_PAX_Taunt.anm",
					"animations\\Jax_PAX_Idle1.anm"
				},
                Image = LoLPath + imgPath + "Jax_4.jpg",
                Background = LoLPath + imgPath + "Jax_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("百夫长")
            {
                Files = 
				{
					"JaxLoadScreen_5.dds",
					"jax_jaximus_TX_CM.dds",
					"jax_jaximus.skl",
					"jax_jaximus.skn",
					"animations\\jax_run.anm",
					"animations\\jax_taunt.anm",
					"animations\\jax_idle1.anm",
					"animations\\jax_jaximus_Death.anm"
				},
                Image = LoLPath + imgPath + "Jax_5.jpg",
                Background = LoLPath + imgPath + "Jax_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("少林武僧")
            {
                Files = 
				{
					"JaxLoadScreen_6.dds",
					"jax_shaolin_TX_CM.dds",
					"Jax_shaolin.skl",
					"Jax_shaolin.skn",
					"animations\\jax_shaolin_run.anm",
					"animations\\jax_taunt.anm",
					"animations\\jax_idle1.anm",
					"animations\\jax_death.anm",
					"animations\\jax_shaolin_spell2.anm"
				},
                Image = LoLPath + imgPath + "Jax_6.jpg",
                Background = LoLPath + imgPath + "Jax_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("复仇武神")
            {
                Files = 
				{
					"JaxLoadScreen_7.dds",
					"jax_immortal_TX_CM.dds",
					"jax_immortal.skl",
					"jax_immortal.skn",
					"animations\\jax_shaolin_run.anm",
					"animations\\jax_taunt.anm",
					"animations\\jax_idle1.anm",
					"animations\\jax_death.anm",
					"animations\\jax_shaolin_spell2.anm"
				},
                Image = LoLPath + imgPath + "Jax_7.jpg",
                Background = LoLPath + imgPath + "Jax_Splash_7.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("J-未来守护者·杰斯", "Jayce")
            {
                New = true
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"JayceLoadScreen.dds",
					"Jayce_base_TX_CM.dds",
					"Jayce.skl",
					"Jayce.skn",
					"Jayce_Base.manifest",
					"Animations\\jayce_melee_attack1.anm",
					"Animations\\jayce_melee_attack2.anm",
					"Animations\\jayce_melee_idle1.anm",
					"Animations\\jayce_melee_spell3.anm",
					"Animations\\jayce_melee_run1.anm",
					"Animations\\jayce_melee_spell1.anm",
					"Animations\\Jayce_melee_attack3.anm",
					"Animations\\Jayce_Melee_Passive.anm",
					"Animations\\Jayce_death.anm",
					"Animations\\Jayce_laugh.anm",
					"Animations\\Jayce_melee_run2.anm",
					"Animations\\Jayce_taunt.anm",
					"Animations\\Jayce_joke.anm",
					"Animations\\Jayce_Channel.anm",
					"Animations\\Jayce_Channel_wndup.anm"
				},
                Image = LoLPath + imgPath + "Jayce_0.jpg",
                Background = LoLPath + imgPath + "Jayce_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("全金属狂潮")
            {
                Files = 
				{
					"JayceLoadScreen_1.dds",
					"Jayce_sentinel_TX_CM.dds",
					"Jayce_sentinel.skl",
					"Jayce_sentinel.skn",
					"Jayce_Base.manifest",
					"Animations\\jayce_ranged_attack1.anm",
					"Animations\\jayce_ranged_spell1.anm",
					"Animations\\jayce_ranged_run1.anm",
					"Animations\\jayce_ranged_spell2_attack1.anm",
					"Animations\\Jayce_ranged_attack2.anm",
					"Animations\\Jayce_Ranged_Passive.anm",
					"Animations\\Jayce_ranged_spell3.anm",
					"Animations\\Jayce_ranged_run2.anm",
					"Animations\\jayce_ranged_idle1.anm"
				},
                Image = LoLPath + imgPath + "Jayce_1.jpg",
                Background = LoLPath + imgPath + "Jayce_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("蔷薇绅士")
            {
                Files = 
				{
					"JayceLoadScreen_2.dds",
					"jayce_gentlemen_TX_CM.dds",
					"Jayce_Gentleman.skl",
					"Jayce_Gentleman.skn",
					"Jayce_Gentleman.manifest",
					"Animations\\jayce_ranged_attack1.anm",
					"Animations\\jayce_ranged_spell1.anm",
					"Animations\\jayce_ranged_run1.anm",
					"Animations\\jayce_ranged_spell2_attack1.anm",
					"Animations\\Jayce_ranged_attack2.anm",
					"Animations\\Jayce_Ranged_Passive.anm",
					"Animations\\Jayce_ranged_spell3.anm",
					"Animations\\Jayce_ranged_run2.anm",
					"Animations\\jayce_ranged_idle1.anm"
				},
                Image = LoLPath + imgPath + "Jayce_2.jpg",
                Background = LoLPath + imgPath + "Jayce_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("K-卡尔玛·天启者", "Karma")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"KarmaLoadScreen.dds",
					"karma_base_TX_CM.dds",
					"Karma.skl",
					"Karma.skn"
				},
                Image = LoLPath + imgPath + "Karma_0.jpg",
                Background = LoLPath + imgPath + "Karma_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("日冕女神")
            {
                Files = 
				{
					"KarmaLoadScreen_1.dds",
					"karma_sungoddess_TX_CM.dds",
					"Karma_sungoddess.skl",
					"Karma_sungoddess.skn"
				},
                Image = LoLPath + imgPath + "Karma_1.jpg",
                Background = LoLPath + imgPath + "Karma_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("樱花乱舞")
            {
                Files = 
				{
					"KarmaLoadScreen_2.dds",
					"karma_geisha_TX_CM.dds",
					"Karma_geisha.skl",
					"Karma_geisha.skn"
				},
                Image = LoLPath + imgPath + "Karma_2.jpg",
                Background = LoLPath + imgPath + "Karma_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("K-卡尔萨斯·死亡颂唱者", "Karthus")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"KarthusLoadScreen.dds",
					"Karthus.dds",
					"Karthus.skl",
					"Karthus.skn"
				},
                Image = LoLPath + imgPath + "Karthus_0.jpg",
                Background = LoLPath + imgPath + "Karthus_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("幽灵幻影")
            {
                Files = 
				{
					"KarthusLoadScreen_1.dds",
					"Karthus_Phantom_TX_CM.dds",
					"Karthus_Phantom.skl",
					"Karthus_Phantom.skn"
				},
                Image = LoLPath + imgPath + "Karthus_1.jpg",
                Background = LoLPath + imgPath + "Karthus_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("自由女神")
            {
                Files = 
				{
					"KarthusLoadScreen_2.dds",
					"karthas_liberty_TX_CM.dds",
					"Karthus_Liberty.skl",
					"Karthus_Liberty.skn"
				},
                Image = LoLPath + imgPath + "Karthus_2.jpg",
                Background = LoLPath + imgPath + "Karthus_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("死神")
            {
                Files = 
				{
					"KarthusLoadScreen_3.dds",
					"karthus_grimreaper_TX_CM.dds",
					"karthus_grimreaper.skl",
					"karthus_grimreaper.skn"
				},
                Image = LoLPath + imgPath + "Karthus_3.jpg",
                Background = LoLPath + imgPath + "Karthus_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("五杀摇滚主唱")
            {
                Files = 
				{
					"KarthusLoadScreen_4.dds",
					"karthus_pentakill_TX_CM.dds",
					"Karthus_pentakill.skl",
					"Karthus_pentakill.skn"
				},
                Image = LoLPath + imgPath + "Karthus_4.jpg",
                Background = LoLPath + imgPath + "Karthus_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("K-卡萨丁·虚空行者", "Kassadin")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"KassadinLoadScreen.dds",
					"Kassadin.dds",
					"Kassadin.skl",
					"Kassadin.skn",
					"Animations\\Kassadin_Run.anm",
					"Animations\\Kassadin_Idle2.anm",
					"Animations\\kassadin_spell2.anm"
				},
                Image = LoLPath + imgPath + "Kassadin_0.jpg",
                Background = LoLPath + imgPath + "Kassadin_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("寒冰王座")
            {
                Files = 
				{
					"KassadinLoadScreen_1.dds",
					"Kassadin_festival_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Kassadin_1.jpg",
                Background = LoLPath + imgPath + "Kassadin_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("深海一号")
            {
                Files = 
				{
					"KassadinLoadScreen_2.dds",
					"kassadin_deep_TX_CM.dds",
					"Kassadin_deep.skl",
					"Kassadin_deep.skn",
					"Animations\\Kassadin_deep_Run.anm"
				},
                Image = LoLPath + imgPath + "Kassadin_2.jpg",
                Background = LoLPath + imgPath + "Kassadin_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("虚空前世")
            {
                Files = 
				{
					"KassadinLoadScreen_3.dds",
					"kassadin_prevoid_TX_CM.dds",
					"kassadin_prevoid.skl",
					"kassadin_prevoid.skn"
				},
                Image = LoLPath + imgPath + "Kassadin_3.jpg",
                Background = LoLPath + imgPath + "Kassadin_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("先驱行者⊙特效")
            {
                Files = 
				{
					"KassadinLoadScreen_4.dds",
					"kassadin_darkblade_TX_CM.dds",
					"kassadin_darkblade.skl",
					"kassadin_darkblade.skn",
					"Animations\\Kassadin_darkblade_Run.anm",
					"Animations\\Kassadin_darkblade_idle2.anm",
					"Animations\\Kassadin_darkblade_spell2.anm"
				},
                Image = LoLPath + imgPath + "Kassadin_4.jpg",
                Background = LoLPath + imgPath + "Kassadin_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Kassadin_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"voidblade.sco",
					"voidblade_glow.dds",
					"voidslash.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("寒冰王座");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("深海一号");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("虚空前世");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("先驱行者")
            {
                Files = 
				{
					"kassadin_darkblade_01.sco",
					"kassadin_darkblade_glow.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("K-卡特琳娜·不祥之刃", "Katarina")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"KatarinaLoadScreen.dds",
					"katarina_base_2012_TX_CM.dds",
					"katarina.skl",
					"katarina.skn"
				},
                Image = LoLPath + imgPath + "Katarina_0.jpg",
                Background = LoLPath + imgPath + "katarina_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("赏金猎人")
            {
                Files = 
				{
					"KatarinaLoadScreen_1.dds",
					"katarina_mercenary_2012_TX_CM.dds",
					"katarina_mercenary.skl",
					"katarina_mercenary.skn.skn"
				},
                Image = LoLPath + imgPath + "Katarina_1.jpg",
                Background = LoLPath + imgPath + "katarina_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("红牌！退场！")
            {
                Files = 
				{
					"KatarinaLoadScreen_2.dds",
					"Katarina_Referee_2012_TX_CM.dds",
					"Katarina_referee.skl",
					"Katarina_referee.skn"
				},
                Image = LoLPath + imgPath + "Katarina_2.jpg",
                Background = LoLPath + imgPath + "katarina_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("海贼魅影")
            {
                Files = 
				{
					"KatarinaLoadScreen_3.dds",
					"katarina_pirate_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Katarina_3.jpg",
                Background = LoLPath + imgPath + "katarina_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("暗夜猫女")
            {
                Files = 
				{
					"KatarinaLoadScreen_4.dds",
					"katarina_cat_2012_TX_CM.dds",
					"katarina_cat.skl",
					"katarina_cat.skn"
				},
                Image = LoLPath + imgPath + "Katarina_4.jpg",
                Background = LoLPath + imgPath + "katarina_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("前线指挥官")
            {
                Files = 
				{
					"KatarinaLoadScreen_5.dds",
					"katarina_noxus_2012_TX_CM.dds",
					"katarina_noxus.skl",
					"katarina_noxus.skn"
				},
                Image = LoLPath + imgPath + "Katarina_5.jpg",
                Background = LoLPath + imgPath + "katarina_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("沙漠风暴⊙特效")
            {
                Files = 
				{
					"KatarinaLoadScreen_6.dds",
					"katarina_desert_TX_CM.dds",
					"Katarina_desert.skl",
					"Katarina_desert.skn"
				},
                Image = LoLPath + imgPath + "Katarina_6.jpg",
                Background = LoLPath + imgPath + "katarina_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("夺命美人⊙特效")
            {
                Files = 
				{
					"KatarinaLoadScreen_7.dds",
					"katarina_xmas_TX_CM.dds",
					"katarina_xmas.skl",
					"katarina_xmas.skn"
				},
                Image = LoLPath + imgPath + "Katarina_7.jpg",
                Background = LoLPath + imgPath + "katarina_Splash_7.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Katarina_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"kat_dagger_01.sco",
					"kat_dagger.dds",
					"katarina_deathylotus.dds",
					"Katarina_DeathLotus_trail.dds",
					"color-KatarinaSmoke"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("赏金猎人");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("红牌！退场！");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("海贼魅影");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("暗夜猫女");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("前线指挥官");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("沙漠风暴")
            {
                Files = 
				{
					"kat_sand_blade.sco",
					"katarina_desert_blade.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("夺命美人")
            {
                Files = 
				{
					"Katarina_Xmas_W_Blades.sco",
					"katarina_xmas_TX_CM.dds",
					"katarina_xmas_deathylotus.dds",
					"katarina_xmas_deathlotus_trail",
					"katarina_xmas_cloud_colormap.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("K-凯尔·审判天使", "Kayle")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"KayleLoadScreen.dds",
					"kayle_base_TX_CM.dds",
					"Kayle.skl",
					"Kayle.skn"
				},
                Image = LoLPath + imgPath + "Kayle_0.jpg",
                Background = LoLPath + imgPath + "Kayle_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("银白审批")
            {
                Files = 
				{
					"KayleLoadScreen_1.dds",
					"kayle_silver2011_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Kayle_1.jpg",
                Background = LoLPath + imgPath + "Kayle_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("末日天使")
            {
                Files = 
				{
					"KayleLoadScreen_2.dds",
					"kayle_viridian2011_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Kayle_2.jpg",
                Background = LoLPath + imgPath + "Kayle_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("大天使长米迦勒")
            {
                Files = 
				{
					"KayleLoadScreen_3.dds",
					"kayle_helmetless2011_TX_CM.dds",
					"kayle_helmetless.skl",
					"kayle_helmetless.skn"
				},
                Image = LoLPath + imgPath + "Kayle_3.jpg",
                Background = LoLPath + imgPath + "Kayle_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("战场女武神")
            {
                Files = 
				{
					"KayleLoadScreen_4.dds",
					"kayle_gunmetal_TX_CM.dds",
					"kayle_gunmetal.skl",
					"kayle_gunmetal.skn"
				},
                Image = LoLPath + imgPath + "Kayle_4.jpg",
                Background = LoLPath + imgPath + "Kayle_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("圣光审判")
            {
                Files = 
				{
					"KayleLoadScreen_5.dds",
					"kayle_judgement_TX_CM.dds",
					"Kayle_Judgement.skl",
					"Kayle_Judgement.skn"
				},
                Image = LoLPath + imgPath + "Kayle_5.jpg",
                Background = LoLPath + imgPath + "Kayle_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("钢铁之翼")
            {
                Files = 
				{
					"KayleLoadScreen_6.dds",
					"kayle_metalwinged_TX_CM.dds",
					"kayle_metalwinged.skl",
					"kayle_metalwinged.skn"
				},
                Image = LoLPath + imgPath + "Kayle_6.jpg",
                Background = LoLPath + imgPath + "Kayle_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("K-凯南·狂暴之心", "Kennen")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"KennenLoadScreen.dds",
					"Kennen.dds",
					"Kennen.skl",
					"Kennen.skn",
					"Animations\\Kennen_Idle1.anm",
					"Animations\\Kennen_Idle3.anm",
					"Animations\\Kennen_Run.anm",
					"Animations\\Kennen_Spell2.anm",
					"Animations\\Kennen_Taunt.anm"
				},
                Image = LoLPath + imgPath + "Kennen_0.jpg",
                Background = LoLPath + imgPath + "Kennen_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("红色彗星⊙特效")
            {
                Files = 
				{
					"KennenLoadScreen_1.dds",
					"Kennen_red.dds"
				},
                Image = LoLPath + imgPath + "Kennen_1.jpg",
                Background = LoLPath + imgPath + "Kennen_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("银色闪电⊙特效")
            {
                Files = 
				{
					"KennenLoadScreen_2.dds",
					"Kennen_blue.dds"
				},
                Image = LoLPath + imgPath + "Kennen_2.jpg",
                Background = LoLPath + imgPath + "Kennen_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("空手道")
            {
                Files = 
				{
					"KennenLoadScreen_3.dds",
					"kennen_karate_TX_CM.dds",
					"Kennen_Karate.skl",
					"Kennen_Karate.skn",
					"Animations\\Kennen_Karate_Idle1.anm",
					"Animations\\Kennen_Karate_Idle3.anm",
					"Animations\\Kennen_Karate_Run.anm",
					"Animations\\Kennen_Karate_Spell2.anm"
				},
                Image = LoLPath + imgPath + "Kennen_3.jpg",
                Background = LoLPath + imgPath + "Kennen_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("医学博士⊙特效")
            {
                Files = 
				{
					"KennenLoadScreen_4.dds",
					"kennen_dr_TX_CM.dds",
					"Kennen_dr.skl",
					"Kennen_dr.skn",
					"Animations\\Kennen_Idle1.anm",
					"Animations\\Kennen_Idle3.anm",
					"Animations\\Kennen_Karate_Run.anm"
				},
                Image = LoLPath + imgPath + "Kennen_4.jpg",
                Background = LoLPath + imgPath + "Kennen_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("刺客信条")
            {
                Files = 
				{
					"KennenLoadScreen_5.dds",
					"kennen_arctic_TX_CM.dds",
					"Kennen_arctic.skl",
					"Kennen_arctic.skn",
					"Animations\\Kennen_Idle1.anm",
					"Animations\\Kennen_Idle3.anm",
					"Animations\\Kennen_Run.anm",
					"Animations\\Kennen_Spell2.anm",
					"Animations\\Kennen_arctic_Taunt.anm"
				},
                Image = LoLPath + imgPath + "Kennen_5.jpg",
                Background = LoLPath + imgPath + "Kennen_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Kennen_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"shuriken.sco",
					"kennen_no_shuriken.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("红色彗星")
            {
                Files = 
				{
					"shuriken.sco",
					"kennen_ns_red.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("银色闪电")
            {
                Files = 
				{
					"shuriken.sco",
					"kennen_ns_blue.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("空手道");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("医学博士")
            {
                Files = 
				{
					"kennen_dr_weapon.sco",
					"kennen_dr_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("刺客信条");
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("K-卡兹克·虚空掠夺者", "Khazix")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"Skins\\Base\\KhazixLoadScreen.dds",
					"Skins\\Base\\khazix_base_CM_TX.dds",
					"Skins\\Base\\Khazix_Base.skl",
					"Skins\\Base\\Khazix_Base.skn"
				},
                Image = LoLPath + imgPath + "Khazix_0.jpg",
                Background = LoLPath + imgPath + "Khazix_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("机械装甲")
            {
                Files = 
				{
					"Skins\\Skin01\\KhazixLoadScreen_1.dds",
					"Skins\\Skin01\\Khazix_droid_TX_CM.dds",
					"Skins\\Skin01\\Khazix_Droid.skl",
					"Skins\\Skin01\\Khazix_Droid.skn"
				},
                Image = LoLPath + imgPath + "Khazix_1.jpg",
                Background = LoLPath + imgPath + "Khazix_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("K-克格莫·深渊巨口", "KogMaw")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"KogMawLoadScreen.dds",
					"KogMaw_TX_CM.dds",
					"KogMaw.skl",
					"KogMaw.skn",
					"Animations\\KogMaw_idle1.anm",
					"Animations\\KogMaw_idle2.anm",
					"Animations\\KogMaw_idle3.anm",
					"Animations\\KogMaw_idle5.anm",
					"Animations\\KogMaw_dance.anm",
					"Animations\\KogMaw_laugh.anm",
					"Animations\\KogMaw_taunt.anm",
					"Animations\\KogMaw_run.anm",
					"Animations\\KogMaw_attack1.anm",
					"Animations\\KogMaw_attack2.anm",
					"Animations\\KogMaw_spell1.anm",
					"Animations\\KogMaw_spell2.anm",
					"Animations\\KogMaw_spell3.anm",
					"Animations\\KogMaw_spell4.anm",
					"Animations\\KogMaw_joke.anm",
					"Animations\\kogmaw_channel.anm",
					"Animations\\kogmaw_channel_windup.anm",
					"Animations\\KogMaw_deathrun.anm"
				},
                Image = LoLPath + imgPath + "KogMaw_0.jpg",
                Background = LoLPath + imgPath + "KogMaw_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("毛毛虫")
            {
                Files = 
				{
					"KogMawLoadScreen_1.dds",
					"kogmaw_catterpillar_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "KogMaw_1.jpg",
                Background = LoLPath + imgPath + "KogMaw_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("索诺拉沙虫")
            {
                Files = 
				{
					"KogMawLoadScreen_2.dds",
					"kogmaw_poisonfrog_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "KogMaw_2.jpg",
                Background = LoLPath + imgPath + "KogMaw_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("帝王斑蝶")
            {
                Files = 
				{
					"KogMawLoadScreen_3.dds",
					"kogmaw_butterfly_TX_CM.dds",
					"KogMaw_butterfly.skl",
					"KogMaw_butterfly.skn",
					"Animations\\kogmaw_butterfly_idle1.anm",
					"Animations\\kogmaw_butterfly_idle2.anm",
					"Animations\\kogmaw_butterfly_idle3.anm",
					"Animations\\kogmaw_butterfly_idle5.anm",
					"Animations\\kogmaw_butterfly_dance.anm",
					"Animations\\kogmaw_butterfly_laugh.anm",
					"Animations\\kogmaw_butterfly_taunt.anm",
					"Animations\\kogmaw_butterfly_run.anm",
					"Animations\\kogmaw_butterfly_attack1.anm",
					"Animations\\kogmaw_butterfly_attack2.anm",
					"Animations\\kogmaw_butterfly_spell1.anm",
					"Animations\\kogmaw_butterfly_spell2.anm",
					"Animations\\kogmaw_butterfly_spell3.anm",
					"Animations\\kogmaw_butterfly_spell4.anm",
					"Animations\\kogmaw_butterfly_joke.anm",
					"Animations\\kogmaw_butterfly_channel.anm",
					"Animations\\kogmaw_butterfly_channel_windup.anm",
					"Animations\\kogmaw_butterfly_deathrun.anm"
				},
                Image = LoLPath + imgPath + "KogMaw_3.jpg",
                Background = LoLPath + imgPath + "KogMaw_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("圣诞驯鹿")
            {
                Files = 
				{
					"KogMawLoadScreen_4.dds",
					"kogmaw_rudolph_TX_CM.dds",
					"KogMaw_reindeer.skl",
					"KogMaw_reindeer.skn",
					"Animations\\KogMaw_idle1.anm",
					"Animations\\KogMaw_idle2.anm",
					"Animations\\KogMaw_idle3.anm",
					"Animations\\KogMaw_idle5.anm",
					"Animations\\KogMaw_dance.anm",
					"Animations\\KogMaw_laugh.anm",
					"Animations\\KogMaw_taunt.anm",
					"Animations\\KogMaw_run.anm",
					"Animations\\KogMaw_attack1.anm",
					"Animations\\KogMaw_attack2.anm",
					"Animations\\KogMaw_spell1.anm",
					"Animations\\KogMaw_spell2.anm",
					"Animations\\KogMaw_spell3.anm",
					"Animations\\KogMaw_spell4.anm",
					"Animations\\KogMaw_reindeer_joke.anm"
				},
                Image = LoLPath + imgPath + "KogMaw_4.jpg",
                Background = LoLPath + imgPath + "KogMaw_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("醒狮")
            {
                Files = 
				{
					"KogMawLoadScreen_5.dds",
					"Kogmaw_Dragon_TX_CM.dds",
					"KogMaw_dragon.skl",
					"KogMaw_dragon.skn"
				},
                Image = LoLPath + imgPath + "KogMaw_5.jpg",
                Background = LoLPath + imgPath + "KogMaw_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("深海怪鱼⊙特效")
            {
                Files = 
				{
					"KogMawLoadScreen_6.dds",
					"kogmaw_deepsea_TX_CM.dds",
					"KogMaw_deepsea.skl",
					"KogMaw_deepsea.skn"
				},
                Image = LoLPath + imgPath + "KogMaw_6.jpg",
                Background = LoLPath + imgPath + "KogMaw_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("侏罗纪化石⊙特效")
            {
                Files = 
				{
					"KogMawLoadScreen_7.dds",
					"kogmaw_fossil_TX_CM.dds",
					"kogmaw_fossil.skl",
					"kogmaw_fossil.skn"
				},
                Image = LoLPath + imgPath + "KogMaw_7.jpg",
                Background = LoLPath + imgPath + "KogMaw_Splash_7.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("K-克格莫·深渊巨口", "KogMawDead");
            skin = new Skin("经典")
            {
                Files = 
				{
					"KogMaw_Dead_TX_CM.dds",
					"KogMaw_Dead.skl",
					"KogMaw_Dead.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("毛毛虫")
            {
                Files = 
				{
					"KogMawDeathSkin_cat.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("索诺拉沙虫")
            {
                Files = 
				{
					"KogMawDeathSkin_frog.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("帝王斑蝶")
            {
                Files = 
				{
					"KogMawDeathSkin_butterfly.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("圣诞驯鹿")
            {
                Files = 
				{
					"kogmaw_rudolph_death.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("醒狮")
            {
                Files = 
				{
					"Kogmaw_Dragon_Dead_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("深海怪鱼")
            {
                Files = 
				{
					"kogmaw_deepsea_dead.dds",
					"KogMaw_deepsea_Dead.skl",
					"KogMaw_deepsea_Dead.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("侏罗纪化石")
            {
                Files = 
				{
					"kogmaw_fossil_dead.dds",
					"kogmaw_fossil_dead.skl",
					"kogmaw_fossil_dead.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("K-克格莫·深渊巨口", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"KogMawDeathSkin.dds",
					"KogMawBABskin.dds",
					""
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("毛毛虫")
            {
                Files = 
				{
					"KogMawDeathSkin_cat.dds",
					"KogMawBABskin_cat.dds",
					""
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("索诺拉沙虫")
            {
                Files = 
				{
					"KogMawDeathSkin_frog.dds",
					"KogMawBABskin_frog.dds",
					""
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("帝王斑蝶")
            {
                Files = 
				{
					"KogMawDeathSkin_butterfly.dds",
					"KogMawBABskin_butterfly.dds",
					""
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("圣诞驯鹿")
            {
                Files = 
				{
					"kogmaw_rudolph_death.dds",
					"kogmaw_rudolph_TX_CM_BAB.dds",
					""
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("醒狮")
            {
                Files = 
				{
					"KogMawDeathSkin_dragon.dds",
					"KogMawBABskin_dragon.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("深海怪鱼")
            {
                Files = 
				{
					"kogmaw_deepsea_death.dds",
					"KogMawBABskin.dds",
					""
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("侏罗纪化石")
            {
                Files = 
				{
					"kogmaw_fossil_dead.dds",
					"kogmaw_fossil_TX_CM.dds",
					""
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("L-乐芙兰·诡术妖姬", "Leblanc")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"LeblancLoadScreen.dds",
					"leblanc_base_TX_CM.dds",
					"Leblanc.skl",
					"Leblanc.skn"
				},
                Image = LoLPath + imgPath + "Leblanc_0.jpg",
                Background = LoLPath + imgPath + "Leblanc_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("潮流女王")
            {
                Files = 
				{
					"LeblancLoadScreen_1.dds",
					"leblanc_white_TX_CM.dds",
					"Leblanc_white.skl",
					"Leblanc_white.skn"
				},
                Image = LoLPath + imgPath + "Leblanc_1.jpg",
                Background = LoLPath + imgPath + "Leblanc_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("社会名流")
            {
                Files = 
				{
					"LeblancLoadScreen_2.dds",
					"leblanc_magician_TX_CM.dds",
					"Leblanc_magician.skl",
					"Leblanc_magician.skn"
				},
                Image = LoLPath + imgPath + "Leblanc_2.jpg",
                Background = LoLPath + imgPath + "Leblanc_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("幸福女神")
            {
                Files = 
				{
					"LeblancLoadScreen_3.dds",
					"leblanc_winterbell_TX_CM.dds",
					"Leblanc_winterbell.skl",
					"Leblanc_winterbell.skn"
				},
                Image = LoLPath + imgPath + "Leblanc_3.jpg",
                Background = LoLPath + imgPath + "Leblanc_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("L-乐芙兰·诡术妖姬", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"leblanc_base_alt_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("潮流女王")
            {
                Files = 
				{
					"leblanc_magician_alt_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("社会名流")
            {
                Files = 
				{
					"leblanc_white_alt_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("幸福女神");
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("L-璐璐·仙灵女巫", "Lulu")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"LuluLoadScreen.dds",
					"Lulu_base_TX_CM.dds",
					"Lulu.skl",
					"Lulu.skn"
				},
                Image = LoLPath + imgPath + "Lulu_0.jpg",
                Background = LoLPath + imgPath + "Lulu_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("糖果女巫")
            {
                Files = 
				{
					"LuluLoadScreen1.ssd",
					"Lulu_DarkCandy_TX_CM.dds",
					"Lulu_darkcandy.skl",
					"Lulu_darkcandy.skn"
				},
                Image = LoLPath + imgPath + "Lulu_1.jpg",
                Background = LoLPath + imgPath + "Lulu_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("邪恶女巫")
            {
                Files = 
				{
					"LuluLoadScreen2.dds",
					"Lulu_classic_TX_CM.dds",
					"Lulu_classic.skl",
					"Lulu_classic.skn"
				},
                Image = LoLPath + imgPath + "Lulu_2.jpg",
                Background = LoLPath + imgPath + "Lulu_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("训龙女巫")
            {
                Files = 
				{
					"LuluLoadScreen_3.dds",
					"Lulu_DragonTrainer_TX_CM.dds",
					"Lulu_DragonTrainer.skl",
					"Lulu_DragonTrainer.skn"
				},
                Image = LoLPath + imgPath + "Lulu_3.jpg",
                Background = LoLPath + imgPath + "Lulu_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("L-璐璐·仙灵女巫", "LuluFaerie");
            skin = new Skin("经典")
            {
                Files = 
				{
					"Lulu_base_TX_CM.dds",
					"Lulu_faerie.skl",
					"Lulu_faerie.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("糖果女巫")
            {
                Files = 
				{
					"Lulu_DarkCandy_TX_CM.dds",
					"Lulu_faerie_darkcandy.skl",
					"Lulu_faerie_darkcandy.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("邪恶女巫")
            {
                Files = 
				{
					"Lulu_classic_TX_CM.dds",
					"Lulu_Faerie_classic.skl",
					"Lulu_Faerie_classic.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("训龙女巫")
            {
                Files = 
				{
					"Lulu_DragonTrainer_TX_CM.dds",
					"Lulu_faerie_DragonTrainer.skl",
					"Lulu_faerie_DragonTrainer.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("L-璐璐·仙灵女巫", "LuluPig");
            skin = new Skin("经典")
            {
                Files = 
				{
					"pig.dds",
					"pig.skl",
					"pig.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("糖果女巫")
            {
                Files = 
				{
					"Wolf.dds",
					"Wolf.skl",
					"Wolf.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("邪恶女巫")
            {
                Files = 
				{
					"Wolf.dds",
					"Wolf.skl",
					"Wolf.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("训龙女巫")
            {
                Files = 
				{
					"Wolf.dds",
					"Wolf.skl",
					"Wolf.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("L-李青·盲僧", "LeeSin")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"LeeSinLoadscreen.dds",
					"LeeSin_TX_CM.dds",
					"LeeSin.skl",
					"LeeSin.skn",
					"Animations\\LeeSin_idle1.anm",
					"Animations\\LeeSin_idle2.anm",
					"Animations\\LeeSin_idle3.anm",
					"Animations\\LeeSin_taunt.anm",
					"Animations\\LeeSin_Dash_b.anm"
				},
                Image = LoLPath + imgPath + "LeeSin_0.jpg",
                Background = LoLPath + imgPath + "LeeSin_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("传统僧侣")
            {
                Files = 
				{
					"LeeSinLoadscreen_1.dds",
					"LeeSin_classic_TX_CM.dds",
					"LeeSin_classic.skl",
					"LeeSin_classic.skn"
				},
                Image = LoLPath + imgPath + "LeeSin_1.jpg",
                Background = LoLPath + imgPath + "LeeSin_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("侍僧")
            {
                Files = 
				{
					"LeeSinLoadscreen_2.dds",
					"LeeSin_temple_TX_CM.dds",
					"LeeSin_temple.skl",
					"LeeSin_temple.skn"
				},
                Image = LoLPath + imgPath + "LeeSin_2.jpg",
                Background = LoLPath + imgPath + "LeeSin_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("龙的传人")
            {
                Files = 
				{
					"LeeSinLoadScreen_3.dds",
					"leesin_dragon_TX_CM.dds",
					"LeeSin_dragon.skl",
					"LeeSin_dragon.skn",
					"Animations\\leesin_dragon_idle1.anm",
					"Animations\\leesin_dragon_Idle2.anm",
					"Animations\\LeeSin_idle2.anm",
					"Animations\\leesin_dragon_taunt.anm",
					"Animations\\LeeSin_dragon_Dash_b.anm"
				},
                Image = LoLPath + imgPath + "LeeSin_3.jpg",
                Background = LoLPath + imgPath + "LeeSin_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("至高之拳")
            {
                Files = 
				{
					"LeeSinLoadScreen_4.dds",
					"LeeSin_muayThai_TX_CM.dds",
					"LeeSin_muayThai.skl",
					"LeeSin_muayThai.skn",
					"Animations\\leesin_muayThai_idle1.anm",
					"Animations\\leesin_muayThai_Idle2.anm",
					"Animations\\LeeSin_idle2.anm",
					"Animations\\leesin_muayThai_taunt.anm",
					"Animations\\LeeSin_muayThai_Recall_loop.anm"
				},
                Image = LoLPath + imgPath + "LeeSin_4.jpg",
                Background = LoLPath + imgPath + "LeeSin_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("L-雷欧娜·曙光女神", "Leona")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"LeonaLoadScreen.dds",
					"leona_base_TX_CM.dds",
					"leona.skl",
					"leona.skn",
					"Animations\\leona_attack3.anm",
					"Animations\\leona_run.anm"
				},
                Image = LoLPath + imgPath + "Leona_0.jpg",
                Background = LoLPath + imgPath + "Leona_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("瓦尔基里")
            {
                Files = 
				{
					"LeonaLoadScreen_1.dds",
					"leona_phoenix_TX_CM.dds",
					"leona_phoenix.skl",
					"leona_phoenix.skn",
					"Animations\\leona_phoenix_attack3.anm"
				},
                Image = LoLPath + imgPath + "Leona_1.jpg",
                Background = LoLPath + imgPath + "Leona_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("神圣守卫")
            {
                Files = 
				{
					"LeonaLoadScreen_2.dds",
					"leona_battleworn_TX_CM.dds",
					"leona_battleworn.skl",
					"leona_battleworn.skn",
					"Animations\\leona_attack3.anm",
					"Animations\\leona_battleworn_run.anm"
				},
                Image = LoLPath + imgPath + "Leona_2.jpg",
                Background = LoLPath + imgPath + "Leona_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("钢铁烈阳")
            {
                Files = 
				{
					"LeonaLoadScreen_3.dds",
					"leona_ironsolari_TX_CM.dds",
					"leona_ironsolari.skl",
					"leona_ironsolari.skn"
				},
                Image = LoLPath + imgPath + "Leona_3.jpg",
                Background = LoLPath + imgPath + "Leona_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("L-雷欧娜·曙光女神", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"Leona_dead32.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("瓦尔基里")
            {
                Files = 
				{
					"Leona_phoenix_dead32.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("神圣守卫")
            {
                Files = 
				{
					"Leona_battleworn_dead32.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("钢铁烈阳");
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("L-拉克丝·光辉女郎", "Lux")
            {
                New = true
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"LuxLoadScreen.dds",
					"lux_base_CM_TX.dds",
					"Lux.skl",
					"Lux.skn",
					"BaseLux.manifest"
				},
                Image = LoLPath + imgPath + "Lux_0.jpg",
                Background = LoLPath + imgPath + "Lux_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("奥术光辉")
            {
                Files = 
				{
					"LuxLoadScreen_1.dds",
					"lux_witch_TX_CM.dds",
					"lux_witch.skl",
					"lux_witch.skn",
					"BaseLux.manifest"
				},
                Image = LoLPath + imgPath + "Lux_1.jpg",
                Background = LoLPath + imgPath + "Lux_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("游侠法师")
            {
                Files = 
				{
					"LuxLoadScreen_2.dds",
					"lux_spellthief_TX_CM.dds",
					"lux_spellthief.skl",
					"lux_spellthief.skn",
					"BaseLux.manifest"
				},
                Image = LoLPath + imgPath + "Lux_2.jpg",
                Background = LoLPath + imgPath + "Lux_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("ODST地狱伞兵")
            {
                Files = 
				{
					"LuxLoadScreen_3.dds",
					"lux_commando_TX_CM.dds",
					"Lux_commando.skl",
					"Lux_commando.skn",
					"BaseLux.manifest"
				},
                Image = LoLPath + imgPath + "Lux_3.jpg",
                Background = LoLPath + imgPath + "Lux_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("星际迷航")
            {
                Files = 
				{
					"LuxLoadScreen_4.dds",
					"lux_Imperial_TX_CM.dds",
					"Lux_Imperial.skl",
					"Lux_Imperial.skn",
					"BaseLux.manifest"
				},
                Image = LoLPath + imgPath + "Lux_4.jpg",
                Background = LoLPath + imgPath + "Lux_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("钢铁军团")
            {
                Files = 
				{
					"LuxLoadScreen_5.dds",
					"lux_steellegion_TX_CM.dds",
					"lux_steellegion.skl",
					"lux_steellegion.skn",
					"SteelLegionLux.manifest"
				},
                Image = LoLPath + imgPath + "Lux_5.jpg",
                Background = LoLPath + imgPath + "Lux_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("M-墨菲特·熔岩巨兽", "Malphite")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"MalphiteLoadScreen.dds",
					"malphite.dds",
					"malphite.skl",
					"malphite.skn"
				},
                Image = LoLPath + imgPath + "Malphite_0.jpg",
                Background = LoLPath + imgPath + "Malphite_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("三叶草⊙特效")
            {
                Files = 
				{
					"MalphiteLoadScreen_1.dds",
					"Malphite_Shamrock.dds"
				},
                Image = LoLPath + imgPath + "Malphite_1.jpg",
                Background = LoLPath + imgPath + "Malphite_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("珊瑚礁⊙特效")
            {
                Files = 
				{
					"MalphiteLoadScreen_2.dds",
					"malphite_bildgewater_TX_CM.dds",
					"malphite_reef.skl",
					"malphite_reef.skn"
				},
                Image = LoLPath + imgPath + "Malphite_2.jpg",
                Background = LoLPath + imgPath + "Malphite_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("石破天惊⊙特效")
            {
                Files = 
				{
					"MalphiteLoadScreen_3.dds",
					"Malphite_rockmonster_TX_CM.dds",
					"malphite_rockmonster.skl",
					"malphite_rockmonster.skn"
				},
                Image = LoLPath + imgPath + "Malphite_3.jpg",
                Background = LoLPath + imgPath + "Malphite_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("黑曜石守护者⊙特效")
            {
                Files = 
				{
					"MalphiteLoadScreen_4.dds",
					"malphite_obsidian_TX_CM.dds",
					"malphite_obsidian.skl",
					"malphite_obsidian.skn"
				},
                Image = LoLPath + imgPath + "Malphite_4.jpg",
                Background = LoLPath + imgPath + "Malphite_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冰川巨兽⊙特效")
            {
                Files = 
				{
					"MalphiteLoadScreen_5.dds",
					"malphite_glacial_base_TX_CM.dds",
					"malphite_glacial.skl",
					"malphite_glacial.skn"
				},
                Image = LoLPath + imgPath + "Malphite_5.jpg",
                Background = LoLPath + imgPath + "Malphite_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("M-墨菲特·熔岩巨兽", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"malphite_glow.dds",
					"malphite_molten.dds",
					"RockBits.dds",
					"SeismicShard.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("三叶草")
            {
                Files = 
				{
					"celticmalphite_glow.dds",
					"celticmalphite_molten.dds",
					"celticrockbits.dds",
					"SeismicShard-shamrock.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("珊瑚礁")
            {
                Files = 
				{
					"reefmalphite_glow.dds",
					"reefmalphite_molten.dds",
					"rockbits-reef.dds",
					"SeismicShard-reef.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("石破天惊")
            {
                Files = 
				{
					"malphite_rockmonster_glow_TX_CM.dds",
					"malphite_rockmonster_molten_TX_CM.dds",
					"RockBits.dds",
					"SeismicShard_rockmonster.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("黑曜石守护者")
            {
                Files = 
				{
					"malphite_obsidian_enraged_TX_CM.dds",
					"malphite_obsidian_damaged_TX_CM.dds",
					"RockBits.dds",
					"SeismicShard_osidian.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("冰川巨兽")
            {
                Files = 
				{
					"Malphite_Glacial_Enrrage_Buff_Text.dds",
					"Malphite_Glacial_Obduracy_off.dds",
					"Malphite_Glacial_RockBits.dds",
					"Malphite_Glacial_Seismic_Shard_text.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("M-玛尔扎哈·虚空先知", "Malzahar")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"MalzaharLoadscreen.dds",
					"Malzahar_TX_CM.dds",
					"Malzahar.skl",
					"Malzahar.skn"
				},
                Image = LoLPath + imgPath + "Malzahar_0.jpg",
                Background = LoLPath + imgPath + "Malzahar_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("元老议会")
            {
                Files = 
				{
					"MalzaharLoadScreen_1.dds",
					"MalZahar_Red_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Malzahar_1.jpg",
                Background = LoLPath + imgPath + "Malzahar_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("暗影王子")
            {
                Files = 
				{
					"MalzaharLoadScreen_2.dds",
					"MalZahar_Golden_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Malzahar_2.jpg",
                Background = LoLPath + imgPath + "Malzahar_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("魔灵")
            {
                Files = 
				{
					"MalzaharLoadScreen_3.dds",
					"malzahar_genie_TX_CM.dds",
					"Malzahar_genie.skl",
					"Malzahar_genie.skn"
				},
                Image = LoLPath + imgPath + "Malzahar_3.jpg",
                Background = LoLPath + imgPath + "Malzahar_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("至高君王⊙特效")
            {
                Files = 
				{
					"MalzaharLoadScreen_4.dds",
					"malzahar_darkvoid_TX_CM.dds",
					"Malzahar_darkvoid.skl",
					"Malzahar_darkvoid.skn"
				},
                Image = LoLPath + imgPath + "Malzahar_4.jpg",
                Background = LoLPath + imgPath + "Malzahar_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("M-玛尔扎哈·虚空先知", "MalzaharVoidling");
            skin = new Skin("经典")
            {
                Files = 
				{
					"Malzahar_Voidling_TX_CM.dds",
					"MalzaharVoidling.skl",
					"MalzaharVoidling.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("元老议会");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("暗影王子");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("魔灵")
            {
                Files = 
				{
					"Malzahar_Genie_Voidling_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("至高君王")
            {
                Files = 
				{
					"malzahar_darkvoid_voidling_PET_TX_CM.dds",
					"Malzahar_darkvoid_voidling.skl",
					"Malzahar_darkvoid_voidling.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("M-茂凯·扭曲树精", "Maokai")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"MaokaiLoadScreen.dds",
					"maokai_base_TX_CM.dds",
					"Maokai.skl",
					"Maokai.skn"
				},
                Image = LoLPath + imgPath + "Maokai_0.jpg",
                Background = LoLPath + imgPath + "Maokai_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("烈焰古树")
            {
                Files = 
				{
					"MaokaiLoadScreen_1.dds",
					"maokai_burnt_TX_CM.dds",
					"Maokai_burnt.skl",
					"Maokai_burnt.skn"
				},
                Image = LoLPath + imgPath + "Maokai_1.jpg",
                Background = LoLPath + imgPath + "Maokai_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("图腾古树")
            {
                Files = 
				{
					"MaokaiLoadScreen_2.dds",
					"Maokai_totem_TX_CM.dds",
					"Maokai_totem.skl",
					"Maokai_totem.skn"
				},
                Image = LoLPath + imgPath + "Maokai_2.jpg",
                Background = LoLPath + imgPath + "Maokai_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("喜庆之树")
            {
                Files = 
				{
					"MaokaiLoadScreen_3.dds",
					"maokai_christmas_TX_CM.dds",
					"Maokai_christmas.skl",
					"Maokai_christmas.skn"
				},
                Image = LoLPath + imgPath + "Maokai_3.jpg",
                Background = LoLPath + imgPath + "Maokai_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("鬼影森森")
            {
                Files = 
				{
					"MaokaiLoadScreen_4.dds",
					"Maokai_graveDigger_TX_CM.dds",
					"Maokai_graveDigger.skl",
					"Maokai_graveDigger.skn"
				},
                Image = LoLPath + imgPath + "Maokai_4.jpg",
                Background = LoLPath + imgPath + "Maokai_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("M-茂凯·扭曲树精", "MaokaiSproutling");
            skin = new Skin("经典")
            {
                Files = 
				{
					"maokai_base_TX_CM_v03.dds",
					"Sapling.skn",
					"Sapling.skl"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("烈焰古树")
            {
                Files = 
				{
					"maokai_burnt_TX_CM.dds",
					"Sapling_burnt.skn",
					"Sapling_burnt.skl"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("图腾古树")
            {
                Files = 
				{
					"Maokai_totem_TX_CM.dds",
					"Sapling_totem.skn",
					"Sapling_totem.skl"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("喜庆之树")
            {
                Files = 
				{
					"maokai_christmas_TX_CM.dds",
					"Sapling_christmas.skn",
					"Sapling_christmas.skl"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("喜庆之树")
            {
                Files = 
				{
					"Maokai_graveDigger_TX_CM.dds",
					"Sapling_graveDigger.skn",
					"Sapling_graveDigger.skl"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("M-易·无极剑圣", "MasterYi")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"MasterYiLoadScreen.dds",
					"MasterYi.dds",
					"MasterYi.skl",
					"MasterYi.skn",
					"Animations\\MasterYi_Run.anm",
					"Animations\\MasterYi_Idle1.anm",
					"Animations\\MasterYi_Idle2.anm",
					"Animations\\MasterYi_Attack1.anm",
					"Animations\\MasterYi_Attack2.anm",
					"Animations\\MasterYi_Attack3.anm",
					"Animations\\masteryi_spell1.anm",
					"Animations\\masteryi_spell2.anm",
					"Animations\\masteryi_spell3.anm",
					"Animations\\masteryi_spell4_loop.anm",
					"Animations\\masteryi_spell4_winddown.anm",
					"Animations\\masteryi_spell4_windup.anm"
				},
                Image = LoLPath + imgPath + "Masteryi_0.jpg",
                Background = LoLPath + imgPath + "Masteryi_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("暗影")
            {
                Files = 
				{
					"MasterYiLoadScreen_1.dds",
					"AssassinMasterYi.dds"
				},
                Image = LoLPath + imgPath + "Masteryi_1.jpg",
                Background = LoLPath + imgPath + "Masteryi_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("星战")
            {
                Files = 
				{
					"MasterYiLoadScreen_2.dds",
					"MasterYi_chosen_TX_CM.dds",
					"MasterYi_chosen.skl",
					"MasterYi_chosen.skn"
				},
                Image = LoLPath + imgPath + "Masteryi_2.jpg",
                Background = LoLPath + imgPath + "Masteryi_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("天人合一")
            {
                Files = 
				{
					"MasterYiLoadScreen_3.dds",
					"masteryi_ionian_TX_CM.dds",
					"masteryi_ionian.skl",
					"masteryi_ionian.skn",
					"Animations\\MasterYi_Ionian_Run.anm"
				},
                Image = LoLPath + imgPath + "Masteryi_3.jpg",
                Background = LoLPath + imgPath + "Masteryi_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("侍魂")
            {
                Files = 
				{
					"MasterYiLoadScreen_4.dds",
					"masteryi_samurai_TX_CM.dds",
					"masteryi_samurai.skl",
					"masteryi_samurai.skn",
					"Animations\\MasterYi_Run.anm",
					"Animations\\masteryi_samurai_idle1.anm",
					"Animations\\MasterYi_samurai_Idle2.anm"
				},
                Image = LoLPath + imgPath + "Masteryi_4.jpg",
                Background = LoLPath + imgPath + "Masteryi_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("铁血剑豪")
            {
                Files = 
				{
					"MasterYiLoadScreen_5.dds",
					"masteryi_tribal_TX_CM.dds",
					"masteryi_tribal.skl",
					"masteryi_tribal.skn",
					"Animations\\MasterYi_Run.anm",
					"Animations\\MasterYi_Idle1.anm",
					"Animations\\MasterYi_Idle2.anm",
					"Animations\\masteryi_tribal_attack1.anm",
					"Animations\\masteryi_tribal_attack2.anm",
					"Animations\\masteryi_tribal_attack3.anm",
					"Animations\\masteryi_tribal_spell1.anm",
					"Animations\\masteryi_tribal_spell2.anm",
					"Animations\\masteryi_tribal_spell3.anm",
					"Animations\\masteryi_tribal_spell4_loop.anm",
					"Animations\\masteryi_tribal_spell4_winddown.anm",
					"Animations\\masteryi_tribal_spell4_windup.anm"
				},
                Image = LoLPath + imgPath + "Masteryi_5.jpg",
                Background = LoLPath + imgPath + "Masteryi_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("M-厄运小姐·赏金猎人", "MissFortune")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"MissFortuneLoadScreen.dds",
					"missfortune_base_TX_CM.dds",
					"MissFortune.skl",
					"MissFortune.skn",
					"Animations\\MissFortune_Attack1.anm",
					"Animations\\MissFortune_Attack2.anm",
					"Animations\\MissFortune_Crit.anm",
					"Animations\\MissFortune_Dance.anm",
					"Animations\\MissFortune_Death.anm",
					"Animations\\MissFortune_Idle1.anm",
					"Animations\\MissFortune_Idle2.anm",
					"Animations\\MissFortune_Idle3.anm",
					"Animations\\MissFortune_Joke.anm",
					"Animations\\MissFortune_Laugh.anm",
					"Animations\\MissFortune_Run.anm",
					"Animations\\MissFortune_Run_passive.anm",
					"Animations\\MissFortune_Spell1.anm",
					"Animations\\MissFortune_Spell3.anm",
					"Animations\\MissFortune_Spell4_loop.anm",
					"Animations\\MissFortune_Spell4_winddown.anm",
					"Animations\\MissFortune_Spell4_windup.anm",
					"Animations\\MissFortune_Taunt.anm",
					"Animations\\MissFortune_Attack1.anm",
					"Animations\\missfortune_channel.anm",
					"Animations\\missfortune_channel_windup.anm"
				},
                Image = LoLPath + imgPath + "MissFortune_0.jpg",
                Background = LoLPath + imgPath + "MissFortune_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("西部牛仔")
            {
                Files = 
				{
					"MissFortuneLoadScreen_1.dds",
					"missfortune_cowgirl_TX_CM.dds",
					"missfortune_cowgirl.skl",
					"missfortune_cowgirl.skn"
				},
                Image = LoLPath + imgPath + "MissFortune_1.jpg",
                Background = LoLPath + imgPath + "MissFortune_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("法国皇室")
            {
                Files = 
				{
					"MissFortuneLoadScreen_2.dds",
					"missfortune_waterloo_TX_CM.dds",
					"missfortune_waterloo.skl",
					"missfortune_waterloo.skn"
				},
                Image = LoLPath + imgPath + "MissFortune_2.jpg",
                Background = LoLPath + imgPath + "MissFortune_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("特工狂花")
            {
                Files = 
				{
					"MissFortuneLoadScreen_3.dds",
					"missfortune_agent_TX_CM.dds",
					"missfortune_agent.skl",
					"missfortune_agent.skn",
					"Animations\\missfortune_agent_attack1.anm",
					"Animations\\missfortune_agent_attack2.anm",
					"Animations\\missfortune_agent_crit.anm",
					"Animations\\missfortune_agent_dance.anm",
					"Animations\\missfortune_agent_death.anm",
					"Animations\\missfortune_agent_idle1.anm",
					"Animations\\missfortune_agent_idle2.anm",
					"Animations\\missfortune_agent_idle3.anm",
					"Animations\\missfortune_agent_joke.anm",
					"Animations\\missfortune_agent_laugh.anm",
					"Animations\\missfortune_agent_run.anm",
					"Animations\\missfortune_agent_run_passive.anm",
					"Animations\\missfortune_agent_spell1.anm",
					"Animations\\missfortune_agent_spell3.anm",
					"Animations\\missfortune_agent_spell4_loop.anm",
					"Animations\\missfortune_agent_spell4_winddown.anm",
					"Animations\\missfortune_agent_spell4_windup.anm",
					"Animations\\missfortune_agent_taunt.anm",
					"Animations\\missfortune_agent_channel.anm",
					"Animations\\missfortune_agent_channel_windup.anm"
				},
                Image = LoLPath + imgPath + "MissFortune_3.jpg",
                Background = LoLPath + imgPath + "MissFortune_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("圣诞糖果棒")
            {
                Files = 
				{
					"MissFortuneLoadScreen_4.dds",
					"missfortune_candycane_TX_CM.dds",
					"missfortune_candycane.skl",
					"missfortune_candycane.skn"
				},
                Image = LoLPath + imgPath + "MissFortune_4.jpg",
                Background = LoLPath + imgPath + "MissFortune_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("荒野女警")
            {
                Files = 
				{
					"MissFortuneLoadScreen_5.dds",
					"missfortune_wasteland_TX_CM.dds",
					"missfortune_wasteland.skl",
					"missfortune_wasteland.skn"
				},
                Image = LoLPath + imgPath + "MissFortune_5.jpg",
                Background = LoLPath + imgPath + "MissFortune_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("女黑手党")
            {
                Files = 
				{
					"MissFortuneLoadScreen_6.dds",
					"missfortune_mafia_TX_CM.dds",
					"missfortune_mafia.skl",
					"missfortune_mafia.skn"
				},
                Image = LoLPath + imgPath + "MissFortune_6.jpg",
                Background = LoLPath + imgPath + "MissFortune_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("M-莫德凯撒·金属大师", "Mordekaiser")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"MordekaiserLoadScreen.dds",
					"Mordekaiser.dds",
					"Mordekaiser.skl",
					"Mordekaiser.skn",
					"Animations\\Mordekaiser_Dance.anm",
					"Animations\\Mordekaiser_Attack1.anm"
				},
                Image = LoLPath + imgPath + "Mordekaiser_0.jpg",
                Background = LoLPath + imgPath + "Mordekaiser_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("龙骑士")
            {
                Files = 
				{
					"MordekaiserLoadScreen_1.dds",
					"Dragon_Knight_Mordekaiser.dds"
				},
                Image = LoLPath + imgPath + "Mordekaiser_1.jpg",
                Background = LoLPath + imgPath + "Mordekaiser_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("地狱火")
            {
                Files = 
				{
					"MordekaiserLoadScreen_2.dds",
					"Infernal_Mordekaiser.dds"
				},
                Image = LoLPath + imgPath + "Mordekaiser_2.jpg",
                Background = LoLPath + imgPath + "Mordekaiser_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("五杀摇滚吉他手")
            {
                Files = 
				{
					"MordekaiserLoadScreen_3.dds",
					"mordekaiser_metal_TX_CM.dds",
					"mordekaiser_metal.skl",
					"mordekaiser_metal.skn",
					"Animations\\Mordekaiser_Metal_Dance.anm",
					"Animations\\Mordekaiser_Metal_Attack1.anm"
				},
                Image = LoLPath + imgPath + "Mordekaiser_3.jpg",
                Background = LoLPath + imgPath + "Mordekaiser_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("死亡领主")
            {
                Files = 
				{
					"MordekaiserLoadScreen_4.dds",
					"mordekaiser_destroyer_TX_CM.dds",
					"mordekaiser_destroyer.skl",
					"mordekaiser_destroyer.skn"
				},
                Image = LoLPath + imgPath + "Mordekaiser_4.jpg",
                Background = LoLPath + imgPath + "Mordekaiser_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("M-莫甘娜·堕落天使", "Morgana")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"MorganaLoadScreen.dds",
					"FallenAngel.dds",
					"Morgana.skl",
					"Morgana.skn"
				},
                Image = LoLPath + imgPath + "Morgana_0.jpg",
                Background = LoLPath + imgPath + "Morgana_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("杀戮天使昔拉")
            {
                Files = 
				{
					"MorganaLoadScreen_1.dds",
					"Morgana_FallenAngel_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Morgana_1.jpg",
                Background = LoLPath + imgPath + "Morgana_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("地狱厨房")
            {
                Files = 
				{
					"MorganaLoadScreen_2.dds",
					"morgana_baker_TX_CM.dds",
					"morgana_baker.skl",
					"morgana_baker.skn"
				},
                Image = LoLPath + imgPath + "Morgana_2.jpg",
                Background = LoLPath + imgPath + "Morgana_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("刀锋女王")
            {
                Files = 
				{
					"MorganaLoadScreen_3.dds",
					"morgana_blade_TX_CM.dds",
					"morgana_blade.skl",
					"morgana_blade.skn"
				},
                Image = LoLPath + imgPath + "Morgana_3.jpg",
                Background = LoLPath + imgPath + "Morgana_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("黑色荆棘")
            {
                Files = 
				{
					"MorganaLoadScreen_4.dds",
					"morgana_blackthorn_TX_CM.dds",
					"morgana_blackthorn.skl",
					"morgana_blackthorn.skn"
				},
                Image = LoLPath + imgPath + "Morgana_4.jpg",
                Background = LoLPath + imgPath + "Morgana_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("M-莫甘娜·堕落天使", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"MorganaTrail.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("杀戮天使昔拉")
            {
                Files = 
				{
					"MorganaTrail_red.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("地狱厨房")
            {
                Files = 
				{
					"MorganaTrail.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("刀锋女王")
            {
                Files = 
				{
					"MorganaTrail.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("黑色荆棘")
            {
                Files = 
				{
					"morgana_blackthorn_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("N-内瑟斯·沙漠死神", "Nasus")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"NasusLoadScreen.dds",
					"Nasus.dds",
					"Nasus.skl",
					"Nasus.skn"
				},
                Image = LoLPath + imgPath + "Nasus_0.jpg",
                Background = LoLPath + imgPath + "Nasus_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("星空之门")
            {
                Files = 
				{
					"NasusLoadScreen_1.dds",
					"Nasus_Silver_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Nasus_1.jpg",
                Background = LoLPath + imgPath + "Nasus_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("法老王朝")
            {
                Files = 
				{
					"NasusLoadScreen_2.dds",
					"nasus_pharoah_TX_CM.dds",
					"Nasus_pharaoh.skl",
					"Nasus_pharaoh.skn"
				},
                Image = LoLPath + imgPath + "Nasus_2.jpg",
                Background = LoLPath + imgPath + "Nasus_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("恐惧骑士")
            {
                Files = 
				{
					"NasusLoadScreen_3.dds",
					"nasus_dreadknight_TX_CM.dds",
					"Nasus_dreadknight.skl",
					"Nasus_dreadknight.skn"
				},
                Image = LoLPath + imgPath + "Nasus_3.jpg",
                Background = LoLPath + imgPath + "Nasus_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("警用试作体K-9")
            {
                Files = 
				{
					"NasusLoadScreen_4.dds",
					"nasus_riot_TX_CM.dds",
					"Nasus_riot.skl",
					"Nasus_riot.skn"
				},
                Image = LoLPath + imgPath + "Nasus_4.jpg",
                Background = LoLPath + imgPath + "Nasus_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("N-内瑟斯·沙漠死神", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"ammon_godofdeath.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("星空之门")
            {
                Files = 
				{
					"Nasus_Silver_Avatar.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("法老王朝")
            {
                Files = 
				{
					"nasus_pharoah_ult_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("恐惧骑士")
            {
                Files = 
				{
					"nasus_dreadknight_TX_CM_Alt.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("警用试作体K-9")
            {
                Files = 
				{
					"nasus_riot_ult_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("N-诺提勒斯·深海泰坦", "Nautilus")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"NautilusLoadScreen.dds",
					"nautilus_base_TX_CM.dds",
					"nautilus.skl",
					"nautilus.skn"
				},
                Image = LoLPath + imgPath + "Nautilus_0.jpg",
                Background = LoLPath + imgPath + "Nautilus_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("失落大陆⊙特效")
            {
                Files = 
				{
					"NautilusLoadScreen_1.dds",
					"nautilus_submarine_TX_CM.dds",
					"nautilus_subterranean.skl",
					"nautilus_subterranean.skn"
				},
                Image = LoLPath + imgPath + "Nautilus_1.jpg",
                Background = LoLPath + imgPath + "Nautilus_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("地底迷城⊙特效")
            {
                Files = 
				{
					"NautilusLoadScreen_2.dds",
					"nautilus_subterranean_TX_CM.dds",
					"nautilus_subterranean.skl",
					"nautilus_subterranean.skn"
				},
                Image = LoLPath + imgPath + "Nautilus_2.jpg",
                Background = LoLPath + imgPath + "Nautilus_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("宇航员⊙特效")
            {
                Files = 
				{
					"NautilusLoadScreen_3.dds",
					"nautilus_astronaut_TX_CM.dds",
					"nautilus_astronaut.skl",
					"nautilus_astronaut.skn"
				},
                Image = LoLPath + imgPath + "Nautilus_3.jpg",
                Background = LoLPath + imgPath + "Nautilus_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("N-诺提勒斯·深海泰坦", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"anchor_new_04.sco",
					"nautilus_props_03.dds",
					"rope_chain_07.dds",
					"nautilus_props_16.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("失落大陆")
            {
                Files = 
				{
					"Nautilus_Sub_Anchor_01.sco",
					"nautilus_submarine_props_01.dds",
					"rope_chain_08.dds",
					"nautilus_submarine_props_02.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("地底迷城")
            {
                Files = 
				{
					"Nautilus_NEW_terrainian_anchor_01.sco",
					"nautilus_NEW_terrainian_props_01.dds",
					"rope_chain_10.dds",
					"nautilus_terrainian_props_02.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("宇航员")
            {
                Files = 
				{
					"Nautilus_Astro_Asteriod.sco",
					"nautilus_astro_basthole.dds",
					"rope_chain_10.dds",
					"nautilus_astro_basthole.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("N-奈德丽·狂野女猎手", "Nidalee")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"nidaleeLoadScreen.dds",
					"Nidalee.dds",
					"Nidalee.skl",
					"Nidalee.skn",
					"Animations\\Nidalee_Run.anm",
					"Animations\\Nidalee_Run_Brush.anm"
				},
                Image = LoLPath + imgPath + "Nidalee_0.jpg",
                Background = LoLPath + imgPath + "Nidalee_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("雪装")
            {
                Files = 
				{
					"nidaleeLoadScreen_1.dds",
					"nidalee_snowbunny.dds"
				},
                Image = LoLPath + imgPath + "Nidalee_1.jpg",
                Background = LoLPath + imgPath + "Nidalee_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("丛林猎豹")
            {
                Files = 
				{
					"nidaleeLoadScreen_2.dds",
					"nidalee_leopard.dds"
				},
                Image = LoLPath + imgPath + "Nidalee_2.jpg",
                Background = LoLPath + imgPath + "Nidalee_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("法国女仆")
            {
                Files = 
				{
					"nidaleeLoadScreen_3.dds",
					"Nidalee_Frenchmaid.dds"
				},
                Image = LoLPath + imgPath + "Nidalee_3.jpg",
                Background = LoLPath + imgPath + "Nidalee_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("艳后⊙特效")
            {
                Files = 
				{
					"nidaleeLoadScreen_4.dds",
					"nidalee_cleopatra_TX_CM.dds",
					"Nidalee_cleo.skl",
					"Nidalee_cleo.skn"
				},
                Image = LoLPath + imgPath + "Nidalee_4.jpg",
                Background = LoLPath + imgPath + "Nidalee_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("魅惑女巫⊙特效")
            {
                Files = 
				{
					"nidaleeLoadScreen_5.dds",
					"Nidalee_witch_TX_CM.dds",
					"Nidalee_witch.skl",
					"Nidalee_witch.skn",
					"Animations\\Nidalee_witch_Run.anm",
					"Animations\\Nidalee_witch_Run_Brush.anm"
				},
                Image = LoLPath + imgPath + "Nidalee_5.jpg",
                Background = LoLPath + imgPath + "Nidalee_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("N-奈德丽·狂野女猎手", "Nidalee_Cougar");
            skin = new Skin("经典")
            {
                Files = 
				{
					"Nidalee_Cougar.dds",
					"Nidalee_Cougar.skl",
					"Nidalee_Cougar.skn",
					"Animations\\Nidalee_Cougar_walk.anm",
					"Animations\\Nidalee_Cougar_taunt.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("雪装")
            {
                Files = 
				{
					"Nidalee_Cougar_holiday.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("丛林猎豹")
            {
                Files = 
				{
					"cougar_leopard.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("法国女仆")
            {
                Files = 
				{
					"cougar_Frenchmaid.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("艳后")
            {
                Files = 
				{
					"nidalee_cougarcleo_TX_CM.dds",
					"Nidalee_cougarcleo.skl",
					"Nidalee_cougarcleo.skn",
					"Animations\\Nidalee_Cougar_Cleo_walk.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("魅惑女巫")
            {
                Files = 
				{
					"nidalee_cougar_witch_TX_CM.dds",
					"Nidalee_Cougarwitch.skl",
					"Nidalee_Cougarwitch.skn",
					"Animations\\Nidalee_Cougar_walk.anm",
					"Animations\\Nidalee_Cougar_witch_taunt.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("N-奈德丽·狂野女猎手", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"javelin_01.sco"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("雪装");
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("丛林猎豹");
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("法国女仆");
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("艳后")
            {
                Files = 
				{
					"javelin_new_01.sco"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("魅惑女巫")
            {
                Files = 
				{
					"nidale_witch_javelin.sco"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("N-诺克顿·永恒梦魇", "Nocturne")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"NocturneLoadScreen.dds",
					"nocturne_base_TX_CM.dds",
					"Nocturne.skl",
					"Nocturne.skn",
					"NocturneBase.manifest"
				},
                Image = LoLPath + imgPath + "Nocturne_0.jpg",
                Background = LoLPath + imgPath + "Nocturne_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("蓝焰梦魇⊙特效")
            {
                Files = 
				{
					"NocturneLoadScreen_1.dds",
					"nocturne_frost_TX_CM.dds",
					"Nocturne_frost.skl",
					"Nocturne_frost.skn"
				},
                Image = LoLPath + imgPath + "Nocturne_1.jpg",
                Background = LoLPath + imgPath + "Nocturne_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("幻影梦魇")
            {
                Files = 
				{
					"NocturneLoadScreen_2.dds",
					"nocturne_void_TX_CM.dds",
					"Nocturne_void.skl",
					"Nocturne_void.skn"
				},
                Image = LoLPath + imgPath + "Nocturne_2.jpg",
                Background = LoLPath + imgPath + "Nocturne_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("劫掠梦魇")
            {
                Files = 
				{
					"NocturneLoadScreen_3.dds",
					"nocturne_massacre_TX_CM.dds",
					"Nocturne_massacre.skl",
					"Nocturne_massacre.skn"
				},
                Image = LoLPath + imgPath + "Nocturne_3.jpg",
                Background = LoLPath + imgPath + "Nocturne_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("鬼影重重⊙特效")
            {
                Files = 
				{
					"NocturneLoadScreen_4.dds",
					"nocturne_ghost_TX_CM.dds",
					"Nocturne_ghost.skl",
					"Nocturne_ghost.skn"
				},
                Image = LoLPath + imgPath + "Nocturne_4.jpg",
                Background = LoLPath + imgPath + "Nocturne_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("上古战魂")
            {
                Files = 
				{
					"NocturneLoadScreen_5.dds",
					"nocturne_cyber_templar_TX_CM.dds",
					"nocturne_cyber_templar.skl",
					"nocturne_cyber_templar.skn",
					"CyberNocturne.manifest"
				},
                Image = LoLPath + imgPath + "Nocturne_5.jpg",
                Background = LoLPath + imgPath + "Nocturne_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("N-诺克顿·永恒梦魇", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"nocturne-tail32.dds",
					"clawtrail.dds",
					"darkpath32.dds",
					"nitemarespirit.dds",
					"nocturne-head.dds",
					"smokedisc32.dds",
					"nightmare-tile.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("蓝焰梦魇")
            {
                Files = 
				{
					"nocturne-frosttail32.dds",
					"clawtrailfrost.dds",
					"darkpathfrost32.dds",
					"nitemarespiritfrost.dds",
					"nocturne-frosthead.dds",
					"smokedisc-frost-strong32.dds",
					"nightmare-tile.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("幻影梦魇")
            {
                Files = 
				{
					"nocturne-voidtail32.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("劫掠梦魇")
            {
                Files = 
				{
					"nocturne-voidtail32.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("鬼影重重")
            {
                Files = 
				{
					"nocturne-ghosttail32.dds",
					"clawtrail_ghost.dds",
					"darkpathghost32.dds",
					"nitemarespiritghost.dds",
					"nocturne-head.dds",
					"smokedisc-ghost-strong32.dds",
					"CannibalismSpirits.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("上古战魂")
            {
                Files = 
				{
					"nocturne_cyber_tail_glow.dds",
					"nocturne_cyber_e_beam_center.dds",
					"nocturne_cyber_e_clouds.dds",
					"nitemarespirit.dds",
					"nocturne-head.dds",
					"smokedisc-frost-strong32.dds",
					"nocturne_cyber_e_fear_icon.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("N-努努·雪人骑士", "Nunu")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"NunuLoadScreen.dds",
					"Yeti.dds",
					"Nunu.skl",
					"Nunu.skn",
					"Animations\\nunu_run.anm",
					"Animations\\nunu_taunt.anm",
					"Animations\\nunu_dance.anm",
					"Animations\\nunu_idle1.anm"
				},
                Image = LoLPath + imgPath + "Nunu_0.jpg",
                Background = LoLPath + imgPath + "Nunu_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("荒野巨兽")
            {
                Files = 
				{
					"NunuLoadScreen_1.dds",
					"Yeti_alt.dds"
				},
                Image = LoLPath + imgPath + "Nunu_1.jpg",
                Background = LoLPath + imgPath + "Nunu_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("圣诞狂欢")
            {
                Files = 
				{
					"NunuLoadScreen_2.dds",
					"nunu_workshop_TX_CM.dds",
					"nunu_workshop.skl",
					"nunu_workshop.skn"
				},
                Image = LoLPath + imgPath + "Nunu_2.jpg",
                Background = LoLPath + imgPath + "Nunu_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("脏兮兮")
            {
                Files = 
				{
					"NunuLoadScreen_3.dds",
					"nunu_grungy_TX_CM.dds",
					"nunu_grungy.skl",
					"nunu_grungy.skn"
				},
                Image = LoLPath + imgPath + "Nunu_3.jpg",
                Background = LoLPath + imgPath + "Nunu_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("合金装备")
            {
                Files = 
				{
					"NunuLoadScreen_4.dds",
					"nunu_bot_TX_CM.dds",
					"nunu_bot.skl",
					"nunu_bot.skn",
					"Animations\\nunu_bot_run.anm",
					"Animations\\nunu_bot_taunt.anm",
					"Animations\\nunu_bot_dance.anm",
					"Animations\\nunu_bot_idle1.anm"
				},
                Image = LoLPath + imgPath + "Nunu_4.jpg",
                Background = LoLPath + imgPath + "Nunu_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("攻城巨兽")
            {
                Files = 
				{
					"NunuLoadScreen_5.dds",
					"nunu_battle_TX_CM.dds",
					"nunu_battle.skl",
					"nunu_battle.skn",
					"Animations\\nunu_battle_run.anm",
					"Animations\\nunu_battle_taunt.anm",
					"Animations\\nunu_battle_dance.anm"
				},
                Image = LoLPath + imgPath + "Nunu_5.jpg",
                Background = LoLPath + imgPath + "Nunu_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("O-奥莉安娜·发条魔灵", "Orianna")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"OriannaLoadscreen.dds",
					"orianna_base_TX_CM.dds",
					"orianna.skl",
					"orianna.skn",
					"Animations\\Orianna_death.anm"
				},
                Image = LoLPath + imgPath + "Orianna_0.jpg",
                Background = LoLPath + imgPath + "Orianna_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("哥特女仆")
            {
                Files = 
				{
					"OriannaLoadscreen_1.dds",
					"oriana_goth_TX_CM.dds",
					"orianna_goth.skl",
					"orianna_goth.skn"
				},
                Image = LoLPath + imgPath + "Orianna_1.jpg",
                Background = LoLPath + imgPath + "Orianna_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("木偶奇遇记")
            {
                Files = 
				{
					"OriannaLoadscreen_2.dds",
					"oriana_sewnchaos_TX_CM.dds",
					"orianna_ragdoll.skl",
					"orianna_ragdoll.skn",
					"Animations\\orianna_ragdoll_death.anm"
				},
                Image = LoLPath + imgPath + "Orianna_2.jpg",
                Background = LoLPath + imgPath + "Orianna_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("灵骨工匠")
            {
                Files = 
				{
					"OriannaLoadscreen_3.dds",
					"orianna_assassin_TX_CM.dds",
					"orianna_assassin.skl",
					"orianna_assassin.skn"
				},
                Image = LoLPath + imgPath + "Orianna_3.jpg",
                Background = LoLPath + imgPath + "Orianna_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("O-奥莉安娜·发条魔灵", "OriannaBall");
            skin = new Skin("经典")
            {
                Files = 
				{
					"orianna_base_TX_CM.dds",
					"orianna_ball.skl",
					"orianna_ball.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("哥特女仆")
            {
                Files = 
				{
					"oriana_goth_TX_CM.dds",
					"orianna_goth_ball.skl",
					"orianna_goth_ball.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("木偶奇遇记")
            {
                Files = 
				{
					"oriana_sewnchaos_TX_CM.dds",
					"orianna_ragdoll_ball.skl",
					"orianna_ragdoll_ball.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("灵骨工匠")
            {
                Files = 
				{
					"orianna_assassin_TX_CM.dds",
					"orianna_assassin_ball.skl",
					"orianna_assassin_ball.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("O-奥莉安娜·发条魔灵", "OriannaNoBall");
            skin = new Skin("经典")
            {
                Files = 
				{
					"orianna_base_TX_CM.dds",
					"orianna.skl",
					"orianna.skn",
					"Animations\\Orianna_death.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("哥特女仆")
            {
                Files = 
				{
					"oriana_goth_TX_CM.dds",
					"orianna_goth.skl",
					"orianna_goth.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("木偶奇遇记")
            {
                Files = 
				{
					"oriana_sewnchaos_TX_CM.dds",
					"orianna_ragdoll.skl",
					"orianna_ragdoll.skn",
					"Animations\\Orianna_ragdoll_death.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("灵骨工匠")
            {
                Files = 
				{
					"orianna_assassin_TX_CM.dds",
					"orianna_assassin.skl",
					"orianna_assassin.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary.Secondary = new Champion("O-奥莉安娜·发条魔灵", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"Oriana_ball_base.sco",
					"orianna_base_TX_CM.dds"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("哥特女仆")
            {
                Files = 
				{
					"oriana_gothic_ball.sco",
					"orianna_goth_512_TX_CM.dds"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("木偶奇遇记")
            {
                Files = 
				{
					"orianna_ball_ragdoll.sco",
					"oriana_sewnchaos_TX_CM.dds"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("灵骨工匠")
            {
                Files = 
				{
					"orinna_Assassin_ball.sco",
					"orianna_assassin_TX_CM.dds"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("O-奥拉夫·狂战士", "Olaf")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"OlafLoadScreen.dds",
					"Olaf.dds",
					"Olaf.skl",
					"Olaf.skn"
				},
                Image = LoLPath + imgPath + "Olaf_0.jpg",
                Background = LoLPath + imgPath + "Olaf_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("烈焰猛士")
            {
                Files = 
				{
					"OlafLoadScreen_1.dds",
					"Olaf_Black_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Olaf_1.jpg",
                Background = LoLPath + imgPath + "Olaf_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冰河时代")
            {
                Files = 
				{
					"OlafLoadScreen_2.dds",
					"Olaf_FrostGiant_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Olaf_2.jpg",
                Background = LoLPath + imgPath + "Olaf_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("铁哥们儿⊙特效")
            {
                Files = 
				{
					"OlafLoadScreen_3.dds",
					"olaf_brolaff_TX_CM.dds",
					"Olaf_bro.skl",
					"Olaf_bro.skn"
				},
                Image = LoLPath + imgPath + "Olaf_3.jpg",
                Background = LoLPath + imgPath + "Olaf_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("五杀")
            {
                Files = 
				{
					"OlafLoadScreen_4.dds",
					"olaf_pentakill_TX_CM.dds",
					"olaf_pentakill.skl",
					"olaf_pentakill.skn"
				},
                Image = LoLPath + imgPath + "Olaf_4.jpg",
                Background = LoLPath + imgPath + "Olaf_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("O-奥拉夫·狂战士", "OlafAxe");
            skin = new Skin("经典")
            {
                Files = 
				{
					"Olaf.dds",
					"OlafAxe.skl",
					"OlafAxe.skn",
					"Animations\\OlafAxe_Idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("烈焰猛士")
            {
                Files = 
				{
					"Olaf_Black_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("冰河时代")
            {
                Files = 
				{
					"Olaf_FrostGiant_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("铁哥们儿")
            {
                Files = 
				{
					"olaf_brolaff_TX_CM.dds",
					"OlafAxe_bro.skl",
					"OlafAxe_bro.skn",
					"Animations\\OlafAxe_Bro_Idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("五杀")
            {
                Files = 
				{
					"olaf_pentakill_TX_CM.dds",
					"olaf_pentakill_Ax.skl",
					"olaf_pentakill_Ax.skn",
					"Animations\\OlafAxe_Bro_Idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("O-奥拉夫·狂战士", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"olaf_axe_01.dds",
					""
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("烈焰猛士")
            {
                Files = 
				{
					"olaf_axe_black.dds",
					""
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("冰河时代")
            {
                Files = 
				{
					"olaf_axe_frost.dds",
					""
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("铁哥们儿")
            {
                Files = 
				{
					"olaf_brolaff_axe.dds",
					"OlafAxe_bro.sco"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("五杀")
            {
                Files = 
				{
					"olaf_pentakill_drumstick_02.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("P-潘森·战争之王", "Pantheon")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"PantheonLoadScreen.dds",
					"pantheon.dds",
					"Pantheon.skl",
					"Pantheon.skn"
				},
                Image = LoLPath + imgPath + "Pantheon_0.jpg",
                Background = LoLPath + imgPath + "Pantheon_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("斯巴达之魂")
            {
                Files = 
				{
					"PantheonLoadScreen_1.dds",
					"Golden_Pantheon.dds"
				},
                Image = LoLPath + imgPath + "Pantheon_1.jpg",
                Background = LoLPath + imgPath + "Pantheon_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("万人敌")
            {
                Files = 
				{
					"PantheonLoadScreen_2.dds",
					"Pantheon_Ruthless.dds",
					"Pantheon_Ruthless.skl",
					"Pantheon_Ruthless.skn"
				},
                Image = LoLPath + imgPath + "Pantheon_2.jpg",
                Background = LoLPath + imgPath + "Pantheon_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("英仙座珀尔修斯")
            {
                Files = 
				{
					"PantheonLoadScreen_3.dds",
					"pantheon_perseus_TX_CM.dds",
					"Pantheon_Perseus.skl",
					"Pantheon_Perseus.skn"
				},
                Image = LoLPath + imgPath + "Pantheon_3.jpg",
                Background = LoLPath + imgPath + "Pantheon_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("钢铁意志⊙特效")
            {
                Files = 
				{
					"PantheonLoadScreen_4.dds",
					"Pantheon_metal_TX_CM.dds",
					"Pantheon_Metal.skl",
					"Pantheon_Metal.skn"
				},
                Image = LoLPath + imgPath + "Pantheon_4.jpg",
                Background = LoLPath + imgPath + "Pantheon_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("大夏武士⊙特效")
            {
                Files = 
				{
					"PantheonLoadScreen_5.dds",
					"pantheon_dacianknight_TX_CM.dds",
					"pantheon_dacianknight.skl",
					"pantheon_dacianknight.skn"
				},
                Image = LoLPath + imgPath + "Pantheon_5.jpg",
                Background = LoLPath + imgPath + "Pantheon_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("P-潘森·战争之王", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"Invisible_Spear.dds",
					"pantheon_spear_01.sco",
					"pantheon_spear.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("斯巴达之魂")
            {
                Files = 
				{
					"MP_invisible_spear.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("万人敌")
            {
                Files = 
				{
					"RP_invisible_spear.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("英仙座珀尔修斯")
            {
                Files = 
				{
					"pantheon_perseus_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("钢铁意志")
            {
                Files = 
				{
					"Pantheon_metal_TX_CM.dds",
					"pantheon_metal_spear_MD.sco",
					"Pantheon_metal_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("大夏武士")
            {
                Files = 
				{
					"Invisible_Spear.dds",
					"pantheon_spear_01.sco",
					"pantheon_spear.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("P-波比·钢铁大使", "Poppy")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"PoppyLoadScreen.dds",
					"poppy.dds",
					"Poppy.skl",
					"Poppy.skn"
				},
                Image = LoLPath + imgPath + "Poppy_0.jpg",
                Background = LoLPath + imgPath + "Poppy_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("诺克萨斯")
            {
                Files = 
				{
					"PoppyLoadScreen_1.dds",
					"Noxus_Poppy.dds"
				},
                Image = LoLPath + imgPath + "Poppy_1.jpg",
                Background = LoLPath + imgPath + "Poppy_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("波比的巧克力工坊")
            {
                Files = 
				{
					"PoppyLoadScreen_2.dds",
					"poppy_lolli_TX_CM.dds",
					"Poppy_lolli.skl",
					"Poppy_lolli.skn"
				},
                Image = LoLPath + imgPath + "Poppy_2.jpg",
                Background = LoLPath + imgPath + "Poppy_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("宗师级锻造训练师")
            {
                Files = 
				{
					"PoppyLoadScreen_3.dds",
					"poppy_blacksmith_TX_CM.dds",
					"poppy_blacksmith.skl",
					"poppy_blacksmith.skn"
				},
                Image = LoLPath + imgPath + "Poppy_3.jpg",
                Background = LoLPath + imgPath + "Poppy_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("圣诞玩偶")
            {
                Files = 
				{
					"PoppyLoadScreen_4.dds",
					"poppy_raggedy_TX_CM.dds",
					"Poppy_raggedy.skl",
					"Poppy_raggedy.skn"
				},
                Image = LoLPath + imgPath + "Poppy_4.jpg",
                Background = LoLPath + imgPath + "Poppy_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("军神战甲")
            {
                Files = 
				{
					"PoppyLoadScreen_5.dds",
					"poppy_regalknight_TX_CM.dds",
					"poppy_regalknight.skl",
					"poppy_regalknight.skn"
				},
                Image = LoLPath + imgPath + "Poppy_5.jpg",
                Background = LoLPath + imgPath + "Poppy_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("血色之锤")
            {
                Files = 
				{
					"PoppyLoadScreen_6.dds",
					"poppy_red_knight_TX_CM.dds",
					"poppy_redknight.skl",
					"poppy_redknight.skn"
				},
                Image = LoLPath + imgPath + "Poppy_6.jpg",
                Background = LoLPath + imgPath + "Poppy_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Poppy_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"poppydef_max.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("诺克萨斯")
            {
                Files = 
				{
					"noxuspoppydef_max.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("波比的巧克力工坊")
            {
                Files = 
				{
					"poppy_lolli_max_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("宗师级锻造训练师")
            {
                Files = 
				{
					"poppy_blacksmith_max_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("圣诞玩偶")
            {
                Files = 
				{
					"poppy_raggedy_SS.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("军神战甲")
            {
                Files = 
				{
					"poppy_regalknight_W_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("血色之锤")
            {
                Files = 
				{
					"poppy_red_knight_alt_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("R-拉莫斯·披甲龙龟", "Rammus")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"RammusLoadScreen.dds",
					"Armordillo.dds",
					"Rammus.skl",
					"Rammus.skn"
				},
                Image = LoLPath + imgPath + "Rammus_0.jpg",
                Background = LoLPath + imgPath + "Rammus_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("国王")
            {
                Files = 
				{
					"RammusLoadScreen_1.dds",
					"Armordillo_Alt.dds"
				},
                Image = LoLPath + imgPath + "Rammus_1.jpg",
                Background = LoLPath + imgPath + "Rammus_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("铬金铠甲")
            {
                Files = 
				{
					"RammusLoadScreen_2.dds",
					"Rammus_DarkMetal_CM_TX.dds"
				},
                Image = LoLPath + imgPath + "Rammus_2.jpg",
                Background = LoLPath + imgPath + "Rammus_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("熔火之心")
            {
                Files = 
				{
					"RammusLoadScreen_3.dds",
					"Rammus_FieryMolten_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Rammus_3.jpg",
                Background = LoLPath + imgPath + "Rammus_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("极度深寒⊙特效")
            {
                Files = 
				{
					"RammusLoadScreen_4.dds",
					"Rammus_Frozen_TX_CM.dds",
					"rammus_frozen.skl",
					"rammus_frozen.skn"
				},
                Image = LoLPath + imgPath + "Rammus_4.jpg",
                Background = LoLPath + imgPath + "Rammus_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("忍龟⊙特效")
            {
                Files = 
				{
					"RammusLoadScreen_5.dds",
					"rammus_ninja_TX_CM.dds",
					"Rammus_ninja.skl",
					"Rammus_ninja.skn"
				},
                Image = LoLPath + imgPath + "Rammus_5.jpg",
                Background = LoLPath + imgPath + "Rammus_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("全金属狂潮⊙特效")
            {
                Files = 
				{
					"RammusLoadScreen_6.dds",
					"rammus_metal_TX_CM_.dds",
					"rammus_metal.skl",
					"rammus_metal.skn"
				},
                Image = LoLPath + imgPath + "Rammus_6.jpg",
                Background = LoLPath + imgPath + "Rammus_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("RammusDBC", "RammusDBC");
            skin = new Skin("经典")
            {
                Files = 
				{
					"Armordillo.dds",
					"RammusDBC.skl",
					"RammusDBC.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("国王")
            {
                Files = 
				{
					"Armordillo_Alt.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("铬金铠甲")
            {
                Files = 
				{
					"Rammus_DarkMetal_CM_TX.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("熔火之心")
            {
                Files = 
				{
					"Rammus_FieryMolten_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("极度深寒")
            {
                Files = 
				{
					"Rammus_Frozen_TX_CM.dds",
					"rammus_frozen.skl",
					"rammus_frozen.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("忍龟")
            {
                Files = 
				{
					"rammus_ninja_TX_CM.dds",
					"Rammus_ninja.skl",
					"Rammus_ninja.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("全金属狂潮")
            {
                Files = 
				{
					"rammus_metal_TX_CM_.dds",
					"rammus_metal_DBC.skl",
					"rammus_metal_DBC.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("RammusPB", "RammusPB");
            skin = new Skin("经典")
            {
                Files = 
				{
					"Rammus_Spin.dds",
					"RammusPB.skl",
					"RammusPB.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("国王")
            {
                Files = 
				{
					"Rammus_Spin_Alt.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("铬金铠甲")
            {
                Files = 
				{
					"Rammus_Spin_DarkMetal.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("熔火之心")
            {
                Files = 
				{
					"Rammus_Spin_FieryMolten.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("极度深寒")
            {
                Files = 
				{
					"Rammus_Frozen_Spin.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("忍龟")
            {
                Files = 
				{
					"rammus_ninja_spin.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("全金属狂潮")
            {
                Files = 
				{
					"rammus_metal_spin_TX_CM.dds",
					"rammus_metal_PB.skl",
					"rammus_metal_PB.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("R-雷克顿·荒漠屠夫", "Renekton")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"RenektonLoadScreen.dds",
					"renekton_base_TX_CM.dds",
					"Renekton.skl",
					"Renekton.skn"
				},
                Image = LoLPath + imgPath + "Renekton_0.jpg",
                Background = LoLPath + imgPath + "Renekton_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("星河战队⊙特效")
            {
                Files = 
				{
					"RenektonLoadScreen_1.dds",
					"renekton_galactic_TX_CM.dds",
					"Renekton_galactic.skl",
					"Renekton_galactic.skn"
				},
                Image = LoLPath + imgPath + "Renekton_1.jpg",
                Background = LoLPath + imgPath + "Renekton_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("荒野之咬")
            {
                Files = 
				{
					"RenektonLoadScreen_2.dds",
					"renekton_downunder_TX_CM.dds",
					"Renekton_downunder.skl",
					"Renekton_downunder.skn"
				},
                Image = LoLPath + imgPath + "Renekton_2.jpg",
                Background = LoLPath + imgPath + "Renekton_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("血色暴君")
            {
                Files = 
				{
					"RenektonLoadScreen_3.dds",
					"renekton_brutal_TX_CM.dds",
					"Renekton_brutal.skl",
					"Renekton_brutal.skn"
				},
                Image = LoLPath + imgPath + "Renekton_3.jpg",
                Background = LoLPath + imgPath + "Renekton_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("符文战争")
            {
                Files = 
				{
					"RenektonLoadScreen_4.dds",
					"renekton_rune_wars_TX_CM.dds",
					"renekton_runewars.skl",
					"renekton_runewars.skn"
				},
                Image = LoLPath + imgPath + "Renekton_4.jpg",
                Background = LoLPath + imgPath + "Renekton_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Renekton_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"renektonrage-skin.dds",
					"uv-renektonblade.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("星河战队")
            {
                Files = 
				{
					"renektonrage-skin-galactic.dds",
					"uv-renektonblade-galactic.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("荒野之咬")
            {
                Files = 
				{
					"renektonrage-skin-steakhouse.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("血色暴君")
            {
                Files = 
				{
					"renektonrage-skin-brutal.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("符文战争")
            {
                Files = 
				{
					"renekton_runewars_hot.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("R-雷恩加尔·傲之追猎者", "Rengar")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"RengarLoadScreen.dds",
					"Rengar_base_TX_CM.dds",
					"Rengar_Base.skl",
					"Rengar_Base.skn"
				},
                Image = LoLPath + imgPath + "Rengar_0.jpg",
                Background = LoLPath + imgPath + "Rengar_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("铁血猎人")
            {
                Files = 
				{
					"RengarLoadScreen_1.dds",
					"Rengar_Hunter_TX_CM.dds",
					"Rengar_Hunter.skl",
					"Rengar_Hunter.skn"
				},
                Image = LoLPath + imgPath + "Rengar_1.jpg",
                Background = LoLPath + imgPath + "Rengar_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("R-瑞文·放逐之刃", "Riven")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"RivenLoadScreen.dds",
					"riven_base_TX_CM.dds",
					"Riven.skl",
					"Riven.skn"
				},
                Image = LoLPath + imgPath + "Riven_0.jpg",
                Background = LoLPath + imgPath + "Riven_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("刺客信条")
            {
                Files = 
				{
					"RivenLoadScreen_1.dds",
					"riven_redeemed_TX_CM.dds",
					"riven_redeemed.skl",
					"riven_redeemed.skn"
				},
                Image = LoLPath + imgPath + "Riven_1.jpg",
                Background = LoLPath + imgPath + "Riven_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("血色精锐")
            {
                Files = 
				{
					"RivenLoadScreen_2.dds",
					"riven_crimson_TX_CM.dds",
					"riven_crimson.skl",
					"riven_crimson.skn"
				},
                Image = LoLPath + imgPath + "Riven_2.jpg",
                Background = LoLPath + imgPath + "Riven_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("兔女郎⊙特效")
            {
                Files = 
				{
					"RivenLoadScreen_3.dds",
					"riven_battlebunny_TX_CM.dds",
					"riven_battlebunny.skl",
					"riven_battlebunny.skn"
				},
                Image = LoLPath + imgPath + "Riven_3.jpg",
                Background = LoLPath + imgPath + "Riven_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("永恒荣耀")
            {
                Files = 
				{
					"RivenLoadScreen_4.dds",
					"riven_season2_TX_CM.dds",
					"riven_season2.skl",
					"riven_season2.skn"
				},
                Image = LoLPath + imgPath + "Riven_4.jpg",
                Background = LoLPath + imgPath + "Riven_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("riven_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("刺客信条")
            {
                Files = 
				{
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("血色精锐")
            {
                Files = 
				{
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("兔女郎")
            {
                Files = 
				{
					"Riven_Battlebunny_shield.sco",
					"riven_battlebunny_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("永恒荣耀")
            {
                Files = 
				{
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("R-兰博·机械公敌", "Rumble")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"RumbleLoadScreen.dds",
					"Rumble_base_TX_CM.dds",
					"rumble.skl",
					"rumble.skn",
					"Animations\\Rumble_spell4_60fps.anm"
				},
                Image = LoLPath + imgPath + "Rumble_0.jpg",
                Background = LoLPath + imgPath + "Rumble_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("热带丛林⊙特效")
            {
                Files = 
				{
					"RumbleLoadScreen_1.dds",
					"Rumble_inTheJungle_TX_CM.dds",
					"rumble_jungle.skl",
					"rumble_jungle.skn"
				},
                Image = LoLPath + imgPath + "Rumble_1.jpg",
                Background = LoLPath + imgPath + "Rumble_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("独眼海盗⊙特效")
            {
                Files = 
				{
					"RumbleLoadScreen_2.dds",
					"rumble_bilgerat_TX_CM.dds",
					"rumble_bilgerat.skl",
					"rumble_bilgerat.skn",
					"Animations\\Rumble_bilgerat_spell4.anm"
				},
                Image = LoLPath + imgPath + "Rumble_2.jpg",
                Background = LoLPath + imgPath + "Rumble_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Shaco_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"rumble_rocket_01.sco",
					"rumble_props_03.dds",
					"rumble_props_02.dds",
					"rumble_overheat_base.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("热带丛林")
            {
                Files = 
				{
					"pineapple.sco",
					"rumble_props_04.dds",
					"rumble_props_04.dds",
					"rumble_overheat_jungle.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("独眼海盗")
            {
                Files = 
				{
					"sphere.sco",
					"rumble_cannon_ball_01.dds",
					"missFortune_musket_ball_03.dds",
					"rumble_overheat_pirate.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("R-瑞兹·流浪法师", "Ryze")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"RyzeLoadScreen.dds",
					"Ryze.dds",
					"Ryze.skl",
					"Ryze.skn",
					"Animations\\ryze_spell2.anm",
					"Animations\\Ryze_Run.anm",
					"Animations\\ryze_spell3.anm",
					"Animations\\ryze_spell4.anm",
					"Animations\\Ryze_channel.anm",
					"Animations\\Ryze_Channel_WindUp.anm"
				},
                Image = LoLPath + imgPath + "Ryze_0.jpg",
                Background = LoLPath + imgPath + "Ryze_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("大魔法师")
            {
                Files = 
				{
					"RyzeLoadScreen_1.dds",
					"Ryze2Human_Diffuse.dds"
				},
                Image = LoLPath + imgPath + "Ryze_1.jpg",
                Background = LoLPath + imgPath + "Ryze_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("部落精神")
            {
                Files = 
				{
					"RyzeLoadScreen_2.dds",
					"Ryze_WarPaint_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Ryze_2.jpg",
                Background = LoLPath + imgPath + "Ryze_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("美国大叔")
            {
                Files = 
				{
					"RyzeLoadScreen_3.dds",
					"ryze_unclesam_TX_CM.dds",
					"Ryze_UncleSam.skl",
					"Ryze_UncleSam.skn"
				},
                Image = LoLPath + imgPath + "Ryze_3.jpg",
                Background = LoLPath + imgPath + "Ryze_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("守护者雕像")
            {
                Files = 
				{
					"RyzeLoadScreen_4.dds",
					"ryze_trophy_TX_CM.dds",
					"Ryze_trophy.skl",
					"Ryze_trophy.skn",
					"Animations\\Ryze_trophy_SpellCast2.anm"
				},
                Image = LoLPath + imgPath + "Ryze_4.jpg",
                Background = LoLPath + imgPath + "Ryze_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("宗师级法师训练师")
            {
                Files = 
				{
					"RyzeLoadScreen_5.dds",
					"ryze_scholar_TX_CM.dds",
					"Ryze_scholar.skl",
					"Ryze_scholar.skn",
					"Animations\\Ryze_trophy_SpellCast2.anm"
				},
                Image = LoLPath + imgPath + "Ryze_5.jpg",
                Background = LoLPath + imgPath + "Ryze_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("至死不渝")
            {
                Files = 
				{
					"RyzeLoadScreen_6.dds",
					"ryze_zombie_TX_CM.dds",
					"Ryze_zombie.skl",
					"Ryze_zombie.skn"
				},
                Image = LoLPath + imgPath + "Ryze_6.jpg",
                Background = LoLPath + imgPath + "Ryze_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("恶魔男爵⊙特效")
            {
                Files = 
				{
					"RyzeLoadScreen_7.dds",
					"ryze_voidcrystal_TX_CM.dds",
					"Ryze_voidcrystal.skl",
					"Ryze_voidcrystal.skn",
					"Animations\\ryze_spell2.anm",
					"Animations\\ryze_voidcrystal_run.anm",
					"Animations\\ryze_voidcrystal_Spell3_BOOKMASK.anm",
					"Animations\\ryze_voidcrystal_Spell4.anm",
					"Animations\\ryze_voidcrystal_channel_BOOKMASK.anm",
					"Animations\\ryze_voidcrystal_channel_windup_BOOKMASK.anm"
				},
                Image = LoLPath + imgPath + "Ryze_7.jpg",
                Background = LoLPath + imgPath + "Ryze_Splash_7.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("海贼⊙特效")
            {
                Files = 
				{
					"RyzeLoadScreen_8.dds",
					"ryze_pirate_TX_CM.dds",
					"ryze_pirate.skl",
					"ryze_pirate.skn",
					"Animations\\ryze_pirate_Spell2.anm",
					"Animations\\ryze_pirate_run.anm",
					"Animations\\ryze_voidcrystal_Spell3_BOOKMASK.anm",
					"Animations\\ryze_voidcrystal_Spell4.anm",
					"Animations\\ryze_voidcrystal_channel_BOOKMASK.anm",
					"Animations\\ryze_voidcrystal_channel_windup_BOOKMASK.anm"
				},
                Image = LoLPath + imgPath + "Ryze_8.jpg",
                Background = LoLPath + imgPath + "Ryze_Splash_8.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Ryze_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"color-overload.dds",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("大魔法师")
            {
                Files = 
				{
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("部落精神")
            {
                Files = 
				{
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("美国大叔")
            {
                Files = 
				{
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("守护者雕像")
            {
                Files = 
				{
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("宗师级法师训练师")
            {
                Files = 
				{
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("至死不渝")
            {
                Files = 
				{
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("恶魔男爵")
            {
                Files = 
				{
					"color-overloadred.dds",
					"Ryze_Crystal_Shard.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("海贼")
            {
                Files = 
				{
					"color-overloadred.dds",
					"Ryze_Crystal_Shard.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-瑟庄妮·凛冬之怒", "Sejuani")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"SejuaniLoadScreen.dds",
					"sejuani_base_TX_CM.dds",
					"Sejuani.skl",
					"Sejuani.skn"
				},
                Image = LoLPath + imgPath + "Sejuani_0.jpg",
                Background = LoLPath + imgPath + "Sejuani_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("野兽女王")
            {
                Files = 
				{
					"SejuaniLoadScreen_1.dds",
					"sejuani_beastlord_TX_CM.dds",
					"Sejuani_beastlord.skl",
					"Sejuani_beastlord.skn"
				},
                Image = LoLPath + imgPath + "Sejuani_1.jpg",
                Background = LoLPath + imgPath + "Sejuani_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("死亡骑士")
            {
                Files = 
				{
					"SejuaniLoadScreen_2.dds",
					"sejuani_death_knight_TX_CM.dds",
					"Sejuani_deathknight.skl",
					"Sejuani_deathknight.skn"
				},
                Image = LoLPath + imgPath + "Sejuani_2.jpg",
                Background = LoLPath + imgPath + "Sejuani_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-萨克·恶魔小丑", "Shaco")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"ShacoLoadScreen.dds",
					"Jester.dds",
					"Shaco.skl",
					"Shaco.skn"
				},
                Image = LoLPath + imgPath + "Shaco_0.jpg",
                Background = LoLPath + imgPath + "Shaco_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("恐怖之源")
            {
                Files = 
				{
					"ShacoLoadScreen_1.dds",
					"Shaco_Hatter_TX_CM.dds",
					"shaco_madhatter.skl",
					"shaco_madhatter.skn"
				},
                Image = LoLPath + imgPath + "Shaco_1.jpg",
                Background = LoLPath + imgPath + "Shaco_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("贵族血统")
            {
                Files = 
				{
					"ShacoLoadScreen_2.dds",
					"shaco_yellow_TX_CM.dds",
					"shaco_yellow.skl",
					"shaco_yellow.skn"
				},
                Image = LoLPath + imgPath + "Shaco_2.jpg",
                Background = LoLPath + imgPath + "Shaco_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("胡桃夹子")
            {
                Files = 
				{
					"ShacoLoadScreen_3.dds",
					"shaco_nutcracker_TX_CM_v01.dds",
					"Shaco_nutcracker.skl",
					"Shaco_nutcracker.skn"
				},
                Image = LoLPath + imgPath + "Shaco_3.jpg",
                Background = LoLPath + imgPath + "Shaco_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("小丑工作坊")
            {
                Files = 
				{
					"ShacoLoadScreen_4.dds",
					"shaco_clockwork_TX_CM.dds",
					"Shaco_clockwork.skl",
					"Shaco_clockwork.skn"
				},
                Image = LoLPath + imgPath + "Shaco_4.jpg",
                Background = LoLPath + imgPath + "Shaco_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("飞越疯人院")
            {
                Files = 
				{
					"ShacoLoadScreen_5.dds",
					"shaco_asylum_TX_CM.dds",
					"Shaco_asylum.skl",
					"Shaco_asylum.skn"
				},
                Image = LoLPath + imgPath + "Shaco_5.jpg",
                Background = LoLPath + imgPath + "Shaco_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("韩国面具Style")
            {
                Files = 
				{
					"ShacoLoadScreen_6.dds",
					"Shaco_Korean_TX_CM.dds",
					"Shaco_Korean.skl",
					"Shaco_Korean.skn"
				},
                Image = LoLPath + imgPath + "Shaco_6.jpg",
                Background = LoLPath + imgPath + "Shaco_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Shaco_Box", "ShacoBox");
            skin = new Skin("经典")
            {
                Files = 
				{
					"JackintheBox.dds",
					"JackintheBox.skl",
					"JackintheBox.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("恐怖之源")
            {
                Files = 
				{
					"JackintheBox_Hatter.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("贵族血统")
            {
                Files = 
				{
					"JackintheBox_Royal.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("胡桃夹子");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("小丑工作坊")
            {
                Files = 
				{
					"JackintheBox_Clockwork.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("飞越疯人院")
            {
                Files = 
				{
					"JackintheBox_Asylum.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("韩国面具Style")
            {
                Files = 
				{
					"JackintheBox_Korean.dds",
					"ShacoBox_Korean.skl",
					"ShacoBox_Korean.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("Shaco_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"Jester-copy.dds",
					"JesterDagger.dds",
					"jesterdagger.sco"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("恐怖之源")
            {
                Files = 
				{
					"Shaco_Hatter_Copy_TX_CM.dds",
					"Shaco_Hatter_Dagger_TX_CM.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("贵族血统")
            {
                Files = 
				{
					"Shaco_Yellow_COPY_TX_CM.dds",
					"Shaco_Yellow_Dagger_TX_CM.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("胡桃夹子")
            {
                Files = 
				{
					"shaco_nutcracker_TX_CM_green.dds",
					"JesterDagger.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("小丑工作坊")
            {
                Files = 
				{
					"shaco_clockwork_COPY_TX_CM.dds",
					"shaco_clockwork_TX_CM.dds",
					"shaco_clockwork_weapon.sco"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("飞越疯人院")
            {
                Files = 
				{
					"shaco_asylum_copy.dds",
					"shaco_asylum_knife.dds",
					"AsylumJesterDagger.sco"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("韩国面具Style")
            {
                Files = 
				{
					"shaco_korean_props_01.dds",
					"Shaco_korean_clone_TX.dds",
					"AsylumJesterDagger.sco"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-慎·暮光之眼", "Shen")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"ShenLoadScreen.dds",
					"shen_tex_v4.dds",
					"Shen.skl",
					"Shen.skn"
				},
                Image = LoLPath + imgPath + "Shen_0.jpg",
                Background = LoLPath + imgPath + "Shen_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("极寒")
            {
                Files = 
				{
					"ShenLoadScreen_1.dds",
					"shen_frozen.dds"
				},
                Image = LoLPath + imgPath + "Shen_1.jpg",
                Background = LoLPath + imgPath + "Shen_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("炎爆")
            {
                Files = 
				{
					"ShenLoadScreen_2.dds",
					"shen_yellowjacket.dds"
				},
                Image = LoLPath + imgPath + "Shen_2.jpg",
                Background = LoLPath + imgPath + "Shen_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("主治医师⊙特效")
            {
                Files = 
				{
					"ShenLoadScreen_3.dds",
					"shen_surgeon_TX_CM.dds",
					"shen_surgeon.skl",
					"shen_surgeon.skn"
				},
                Image = LoLPath + imgPath + "Shen_3.jpg",
                Background = LoLPath + imgPath + "Shen_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("鬼武者")
            {
                Files = 
				{
					"ShenLoadScreen_4.dds",
					"shen_oni_TX_CM.dds",
					"Shen_oni.skl",
					"Shen_oni.skn"
				},
                Image = LoLPath + imgPath + "Shen_4.jpg",
                Background = LoLPath + imgPath + "Shen_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("战国大名")
            {
                Files = 
				{
					"ShenLoadScreen_5.dds",
					"shen_samurai_TX_CM.dds",
					"shen_samurai.skl",
					"shen_samurai.skn"
				},
                Image = LoLPath + imgPath + "Shen_5.jpg",
                Background = LoLPath + imgPath + "Shen_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Shen_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"shen_surgeon_blade.sco",
					"shen_surgeon_TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("极寒");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("炎爆");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("主治医师")
            {
                Files = 
				{
					"shen_sword_01.sco",
					"shen_sword_01.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("鬼武者");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("战国大名");
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-希瓦娜·龙血武姬", "Shyvana")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"ShyvanaLoadScreen.dds",
					"shyvana_base_TX_CM.dds",
					"Shyvana.skl",
					"Shyvana.skn"
				},
                Image = LoLPath + imgPath + "Shyvana_0.jpg",
                Background = LoLPath + imgPath + "Shyvana_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("钢之逆鳞")
            {
                Files = 
				{
					"ShyvanaLoadscreen_1.dds",
					"shyvana_knight_TX_CM.dds",
					"Shyvana_knight.skl",
					"Shyvana_knight.skn"
				},
                Image = LoLPath + imgPath + "Shyvana_1.jpg",
                Background = LoLPath + imgPath + "Shyvana_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("骸骨之爪")
            {
                Files = 
				{
					"ShyvanaLoadscreen_2.dds",
					"shyvana_bone_TX_CM.dds",
					"Shyvana_bone.skl",
					"Shyvana_bone.skn"
				},
                Image = LoLPath + imgPath + "Shyvana_2.jpg",
                Background = LoLPath + imgPath + "Shyvana_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("黯黑魔龙")
            {
                Files = 
				{
					"ShyvanaLoadscreen_3.dds",
					"shyvana_shadow_TX_CM.dds",
					"shyvana_shadow.skl",
					"shyvana_shadow.skn"
				},
                Image = LoLPath + imgPath + "Shyvana_3.jpg",
                Background = LoLPath + imgPath + "Shyvana_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("ShyvanaDragon", "ShyvanaDragon");
            skin = new Skin("经典")
            {
                Files = 
				{
					"shyvana_base_dragon_TX_CM.dds",
					"ShyvanaDragon.skl",
					"ShyvanaDragon.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("钢之逆鳞")
            {
                Files = 
				{
					"shyvana_knight_dragon_TX_CM.dds",
					"ShyvanaKnightDragon.skl",
					"ShyvanaKnightDragon.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("骸骨之爪")
            {
                Files = 
				{
					"shyvana_bone_dragon_TX_CM.dds",
					"ShyvanaBoneDragon.skl",
					"ShyvanaBoneDragon.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("黯黑魔龙")
            {
                Files = 
				{
					"shyvana_shadow_dragon_TX_CM.dds",
					"shyvana_shadow.skl",
					"shyvana_shadow.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-辛吉德·炼金术士", "Singed")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"SingedLoadScreen.dds",
					"ChemicalMan.dds",
					"Singed.skl",
					"Singed.skn",
					"Animations\\Singed_Channel.anm",
					"Animations\\Singed_Channel_WindUp.anm",
					"Animations\\singed_dance.anm",
					"Animations\\singed_idle1.anm",
					"Animations\\singed_run.anm",
					"Animations\\singed_taunt.anm"
				},
                Image = LoLPath + imgPath + "Singed_0.jpg",
                Background = LoLPath + imgPath + "Singed_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("防爆士兵⊙特效")
            {
                Files = 
				{
					"SingedLoadScreen_1.dds",
					"chemicalman_riot_TX_CM.dds",
					"singed_riot.skl",
					"singed_riot.skn"
				},
                Image = LoLPath + imgPath + "Singed_1.jpg",
                Background = LoLPath + imgPath + "Singed_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("机械污染")
            {
                Files = 
				{
					"SingedLoadScreen_2.dds",
					"singed_hextech_TX_CM.dds",
					"singed_hextech.skl",
					"singed_hextech.skn"
				},
                Image = LoLPath + imgPath + "Singed_2.jpg",
                Background = LoLPath + imgPath + "Singed_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冲浪高手")
            {
                Files = 
				{
					"SingedLoadScreen_3.dds",
					"singed_surfer_TX_CM.dds",
					"singed_surfer.skl",
					"singed_surfer.skn",
					"Animations\\Singed_Surfer_Channel.anm",
					"Animations\\Singed_Surfer_Channel_WindUp.anm",
					"Animations\\singed_surfer_dance.anm",
					"Animations\\singed_surfer_idle1.anm",
					"Animations\\singed_surfer_run.anm",
					"Animations\\singed_surfer_taunt.anm"
				},
                Image = LoLPath + imgPath + "Singed_3.jpg",
                Background = LoLPath + imgPath + "Singed_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("科学狂人")
            {
                Files = 
				{
					"SingedLoadScreen_4.dds",
					"singed_madscientist_TX_CM.dds",
					"singed_madscientist.skl",
					"singed_madscientist.skn",
					"Animations\\Singed_Channel.anm",
					"Animations\\singed_madscientist_channel_windup.anm",
					"Animations\\singed_dance.anm",
					"Animations\\singed_idle1.anm",
					"Animations\\singed_madscientist_run.anm",
					"Animations\\singed_taunt.anm"
				},
                Image = LoLPath + imgPath + "Singed_4.jpg",
                Background = LoLPath + imgPath + "Singed_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("炼金狂士⊙特效")
            {
                Files = 
				{
					"SingedLoadScreen_5.dds",
					"singed_experiment_TX_CM.dds",
					"singed_experiment.skl",
					"singed_experiment.skn",
					"Animations\\Singed_Channel.anm",
					"Animations\\singed_experiment_Spell5.anm",
					"Animations\\singed_dance.anm",
					"Animations\\singed_idle1.anm",
					"Animations\\singed_experiment_run.anm",
					"Animations\\singed_taunt.anm"
				},
                Image = LoLPath + imgPath + "Singed_5.jpg",
                Background = LoLPath + imgPath + "Singed_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Singed_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"color-poisongas.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("防爆士兵")
            {
                Files = 
				{
					"color-riotgas.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("机械污染");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("冲浪高手");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("科学狂人");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("炼金狂士")
            {
                Files = 
				{
					"color-riotgas_colorblind.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-塞恩·亡灵勇士", "Sion")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"SionLoadScreen.dds",
					"Sion.dds",
					"Sion.skl",
					"Sion.skn"
				},
                Image = LoLPath + imgPath + "Sion_0.jpg",
                Background = LoLPath + imgPath + "Sion_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("钢铁终结者")
            {
                Files = 
				{
					"SionLoadScreen_1.dds",
					"Sion_Metal_TX_CM.dds",
					"Sion_hextech.skl",
					"Sion_hextech.skn"
				},
                Image = LoLPath + imgPath + "Sion_1.jpg",
                Background = LoLPath + imgPath + "Sion_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("舞仙座海格力斯⊙特效")
            {
                Files = 
				{
					"SionLoadScreen_2.dds",
					"sion_barbarian_TX_CM.dds",
					"Sion_barbarian.skl",
					"Sion_barbarian.skn"
				},
                Image = LoLPath + imgPath + "Sion_2.jpg",
                Background = LoLPath + imgPath + "Sion_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("原野伐木工⊙特效")
            {
                Files = 
				{
					"SionLoadScreen_3.dds",
					"sion_lumberJack_TX_CM.dds",
					"Sion_lumberjack.skl",
					"Sion_lumberjack.skn"
				},
                Image = LoLPath + imgPath + "Sion_3.jpg",
                Background = LoLPath + imgPath + "Sion_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("战争机器⊙特效")
            {
                Files = 
				{
					"SionLoadScreen_4.dds",
					"sion_armored_TX_CM.dds",
					"Sion_armored.skl",
					"Sion_armored.skn"
				},
                Image = LoLPath + imgPath + "Sion_4.jpg",
                Background = LoLPath + imgPath + "Sion_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Sion_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"Enrage_Axe.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("钢铁终结者")
            {
                Files = 
				{
					"Enrage_Hammer.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("舞仙座海格力斯")
            {
                Files = 
				{
					"Enrage_Barbarian_Axe.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("原野伐木工")
            {
                Files = 
				{
					"Enrage_Lumberjack_Axe.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("战争机器")
            {
                Files = 
				{
					"enrage_armorsion_axe.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-希维尔·战争女神", "Sivir")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"SivirLoadScreen.dds",
					"Sivir.dds",
					"Sivir.skl",
					"Sivir.skn",
					"Animations\\Sivir_Run.anm"
				},
                Image = LoLPath + imgPath + "Sivir_0.jpg",
                Background = LoLPath + imgPath + "Sivir_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("战场公主")
            {
                Files = 
				{
					"SivirLoadScreen_1.dds",
					"Sivir_warriorprincess_TX_CM.dds",
					"Sivir_warriorprincess.skl",
					"Sivir_warriorprincess.skn"
				},
                Image = LoLPath + imgPath + "Sivir_1.jpg",
                Background = LoLPath + imgPath + "Sivir_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("靓丽女神")
            {
                Files = 
				{
					"SivirLoadScreen_2.dds",
					"Sivir_spectacular_TX_CM.dds",
					"Sivir_spectacular.skl",
					"Sivir_spectacular.skn"
				},
                Image = LoLPath + imgPath + "Sivir_2.jpg",
                Background = LoLPath + imgPath + "Sivir_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("女猎手")
            {
                Files = 
				{
					"SivirLoadScreen_3.dds",
					"sivir_aboriginal_TX_CM.dds",
					"Sivir_aboriginal.skl",
					"Sivir_aboriginal.skn",
					"Animations\\Sivir_Aboriginal_Run.anm"
				},
                Image = LoLPath + imgPath + "Sivir_3.jpg",
                Background = LoLPath + imgPath + "Sivir_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("钢铁之心")
            {
                Files = 
				{
					"SivirLoadScreen_4.dds",
					"sivir_frejlord_TX_CM.dds",
					"Sivir_frejlord.skl",
					"Sivir_frejlord.skn"
				},
                Image = LoLPath + imgPath + "Sivir_4.jpg",
                Background = LoLPath + imgPath + "Sivir_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("创战记")
            {
                Files = 
				{
					"SivirLoadScreen_5.dds",
					"sivir_pax_TX_CM.dds",
					"Sivir_pax.skl",
					"Sivir_pax.skn"
				},
                Image = LoLPath + imgPath + "Sivir_5.jpg",
                Background = LoLPath + imgPath + "Sivir_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-斯卡纳·水晶先锋", "Skarner")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"SkarnerLoadScreen.dds",
					"Skarner_base_TX_CM.dds",
					"Skarner.skl",
					"Skarner.skn",
					"Animations\\Skarner_laugh.anm",
					"Animations\\Skarner_taunt.anm"
				},
                Image = LoLPath + imgPath + "Skarner_0.jpg",
                Background = LoLPath + imgPath + "Skarner_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("沙暴巨蝎⊙特效")
            {
                Files = 
				{
					"SkarnerLoadScreen_1.dds",
					"Skarner_Scorpion_TX_CM.dds",
					"Skarner_scorpion.skl",
					"Skarner_scorpion.skn",
					"Animations\\Skarner_scorpion_laugh.anm",
					"Animations\\Skarner_scorpion_taunt.anm"
				},
                Image = LoLPath + imgPath + "Skarner_1.jpg",
                Background = LoLPath + imgPath + "Skarner_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("远土之灵⊙特效")
            {
                Files = 
				{
					"SkarnerLoadScreen_2.dds",
					"Skarner_Rune_TX_CM.dds",
					"Skarner_rune.skl",
					"Skarner_rune.skn"
				},
                Image = LoLPath + imgPath + "Skarner_2.jpg",
                Background = LoLPath + imgPath + "Skarner_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Skarner_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"skarner_exoskeleton_base.dds",
					"skarner_slash_shockwave_purple.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("沙暴巨蝎")
            {
                Files = 
				{
					"skarner_scorpion_TX_CM_crystalized_v01.dds",
					"skarner_slash_shockwave_orange.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("远土之灵")
            {
                Files = 
				{
					"skarner_runes_exoskeleton.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-娑娜·琴瑟仙女", "Sona")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"SonaLoadScreen.dds",
					"sona_base_TX_CM.dds",
					"Sona.skl",
					"Sona.skn",
					"animations\\sona_joke.anm",
					"animations\\sona_run.anm"
				},
                Image = LoLPath + imgPath + "Sona_0.jpg",
                Background = LoLPath + imgPath + "Sona_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("缪斯女神")
            {
                Files = 
				{
					"SonaLoadScreen_1.dds",
					"sona_muse_TX_CM.dds",
					"Sona_muse.skl",
					"Sona_muse.skn"
				},
                Image = LoLPath + imgPath + "Sona_1.jpg",
                Background = LoLPath + imgPath + "Sona_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("五杀摇滚键盘手")
            {
                Files = 
				{
					"SonaLoadScreen_2.dds",
					"sona_metal_TX_CM.dds",
					"Sona_metal.skl",
					"Sona_metal.skn"
				},
                Image = LoLPath + imgPath + "Sona_2.jpg",
                Background = LoLPath + imgPath + "Sona_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("平安夜女神")
            {
                Files = 
				{
					"SonaLoadScreen_3.dds",
					"sona_silentnight_TX_CM.dds",
					"Sona_silentnight.skl",
					"Sona_silentnight.skn",
					"animations\\sona_silentnight_joke.anm"
				},
                Image = LoLPath + imgPath + "Sona_3.jpg",
                Background = LoLPath + imgPath + "Sona_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("古琴余韵")
            {
                Files = 
				{
					"SonaLoadScreen_4.dds",
					"sona_guqin_TX_CM.dds",
					"Sona_guqin.skl",
					"Sona_guqin.skn",
					"animations\\sona_joke.anm",
					"animations\\sona_guqin_run.anm"
				},
                Image = LoLPath + imgPath + "Sona_4.jpg",
                Background = LoLPath + imgPath + "Sona_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("电玩女神")
            {
                Files = 
				{
					"SonaLoadScreen_5.dds",
					"sona_pax_TX_CM.dds",
					"sona_pax.skl",
					"sona_pax.skn",
					"animations\\sona_pax_Attack1.anm",
					"animations\\sona_pax_Run.anm"
				},
                Image = LoLPath + imgPath + "Sona_5.jpg",
                Background = LoLPath + imgPath + "Sona_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-索拉卡·众星之子", "Soraka")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"sorakaLoadScreen.dds",
					"soraka_base_TX_CM.dds",
					"Soraka.skl",
					"Soraka.skn",
					"animations\\Soraka_Attack1.anm",
					"animations\\Soraka_Attack2.anm",
					"animations\\soraka_channel.anm",
					"animations\\Soraka_Dance.anm",
					"animations\\Soraka_Death.anm",
					"animations\\Soraka_Idle1.anm",
					"animations\\Soraka_Idle2.anm",
					"animations\\Soraka_Idle3.anm",
					"animations\\Soraka_Idle4.anm",
					"animations\\Soraka_Laugh.anm",
					"animations\\Soraka_Run.anm",
					"animations\\Soraka_Spell1.anm",
					"animations\\Soraka_Spell3.anm",
					"animations\\Soraka_Taunt.anm"
				},
                Image = LoLPath + imgPath + "Soraka_0.jpg",
                Background = LoLPath + imgPath + "Soraka_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("森林女神")
            {
                Files = 
				{
					"sorakaLoadScreen_1.dds",
					"soraka_dryad_2012_TX_CM.dds",
					"Soraka_dryad.skl",
					"Soraka_dryad.skn"
				},
                Image = LoLPath + imgPath + "Soraka_1.jpg",
                Background = LoLPath + imgPath + "Soraka_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("月光女神")
            {
                Files = 
				{
					"sorakaLoadScreen_2.dds",
					"soraka_divine_2012_TX_CM.dds",
					"soraka_divine.skl",
					"soraka_divine.skn"
				},
                Image = LoLPath + imgPath + "Soraka_2.jpg",
                Background = LoLPath + imgPath + "Soraka_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-斯维因·策士统领", "Swain")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"SwainLoadScreen.dds",
					"swain_base_TX_CM.dds",
					"Swain.skl",
					"Swain.skn"
				},
                Image = LoLPath + imgPath + "Swain_0.jpg",
                Background = LoLPath + imgPath + "Swain_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("北领前线⊙特效")
            {
                Files = 
				{
					"SwainLoadScreen_1.dds",
					"swain_north_TX_CM.dds",
					"Swain_north.skl",
					"Swain_north.skn"
				},
                Image = LoLPath + imgPath + "Swain_1.jpg",
                Background = LoLPath + imgPath + "Swain_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("海贼参谋⊙特效")
            {
                Files = 
				{
					"SwainLoadScreen_2.dds",
					"swain_bilgewater_TX_CM.dds",
					"Swain_bilgewater.skl",
					"Swain_bilgewater.skn"
				},
                Image = LoLPath + imgPath + "Swain_2.jpg",
                Background = LoLPath + imgPath + "Swain_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("绝代智将⊙特效")
            {
                Files = 
				{
					"SwainLoadScreen_3.dds",
					"swain_grandadmiral_TX_CM.dds",
					"swain_grandadmiral.skl",
					"swain_grandadmiral.skn"
				},
                Image = LoLPath + imgPath + "Swain_3.jpg",
                Background = LoLPath + imgPath + "Swain_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("SwainNoBird", "SwainNoBird");
            skin = new Skin("经典")
            {
                Files = 
				{
					"swain_base_TX_CM.dds",
					"Swain.skl",
					"Swain.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("北领前线")
            {
                Files = 
				{
					"swain_north_TX_CM.dds",
					"Swain_north.skl",
					"Swain_north.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("海贼参谋")
            {
                Files = 
				{
					"swain_bilgewater_TX_CM.dds",
					"Swain_Bilgewater.skl",
					"Swain_Bilgewater.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("绝代智将")
            {
                Files = 
				{
					"swain_grandadmiral_TX_CM.dds",
					"swain_grandadmiral.skl",
					"swain_grandadmiral.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("SwainRaven", "SwainRaven");
            skin = new Skin("经典")
            {
                Files = 
				{
					"swain_demon_base_TX_CM.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("北领前线")
            {
                Files = 
				{
					"swain_demon_north_TX_CM.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("海贼参谋")
            {
                Files = 
				{
					"swain_demon_bilgewater_TX_CM.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("绝代智将")
            {
                Files = 
				{
					"swain_demon_grandadmiral_TX_CM.dds"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary.Secondary = new Champion("SwainBeam", "SwainBeam");
            skin = new Skin("经典")
            {
                Files = 
				{
					"swain_base_TX_CM.dds",
					"Swain_Beatrice.skl",
					"Swain_Beatrice.skn"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("北领前线")
            {
                Files = 
				{
					"swain_north_TX_CM.dds",
					"Swain_Beatrice_north.skl",
					"Swain_Beatrice_north.skn"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("海贼参谋")
            {
                Files = 
				{
					"swain_bilgewater_TX_CM.dds",
					"Swain_Beatrice_Bilgewater.skl",
					"Swain_Beatrice_Bilgewater.skn"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("绝代智将")
            {
                Files = 
				{
					"swain_grandadmiral_TX_CM.dds",
					"Swain_Beatrice_grandadmiral.skl",
					"Swain_Beatrice_grandadmiral.skn"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("S-辛德拉·暗黑元首", "Syndra")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"SyndraLoadScreen.dds",
					"Syndra_base_TX_CM.dds",
					"Syndra.skl",
					"Syndra.skn"
				},
                Image = LoLPath + imgPath + "Syndra_0.jpg",
                Background = LoLPath + imgPath + "Syndra_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("仲裁圣女")
            {
                Files = 
				{
					"SyndraLoadScreen_1.dds",
					"Syndra_Justicar_TX_CM.dds",
					"Syndra_Justicar.skl",
					"Syndra_Justicar.skn"
				},
                Image = LoLPath + imgPath + "Syndra_1.jpg",
                Background = LoLPath + imgPath + "Syndra_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("SyndraOrbs", "SyndraOrbs");
            skin = new Skin("经典")
            {
                Files = 
				{
					"Syndra.skl"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("仲裁圣女")
            {
                Files = 
				{
					"Syndra_Justicar.skl"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("SyndraSphere", "SyndraSphere");
            skin = new Skin("经典")
            {
                Files = 
				{
					"SyndraSphere.skl",
					"SyndraSphere.skn",
					"animations\\SyndraSphere.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("仲裁圣女")
            {
                Files = 
				{
					"SyndraSphere.skl",
					"SyndraSphere.skn",
					"animations\\SyndraSphere.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("T-泰隆·刀锋之影", "Talon")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"TalonLoadScreen.dds",
					"talon_base_TX_CM.dds",
					"Talon.skl",
					"Talon.skn"
				},
                Image = LoLPath + imgPath + "Talon_0.jpg",
                Background = LoLPath + imgPath + "Talon_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("刺客信条")
            {
                Files = 
				{
					"TalonLoadScreen_1.dds",
					"talon_street_TX_CM.dds",
					"Talon_street.skl",
					"Talon_street.skn"
				},
                Image = LoLPath + imgPath + "Talon_1.jpg",
                Background = LoLPath + imgPath + "Talon_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("血色精锐")
            {
                Files = 
				{
					"TalonLoadScreen_2.dds",
					"talon_nemesis_TX_CM.dds",
					"Talon_nemesis.skl",
					"Talon_nemesis.skn"
				},
                Image = LoLPath + imgPath + "Talon_2.jpg",
                Background = LoLPath + imgPath + "Talon_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("银龙裁决⊙特效")
            {
                Files = 
				{
					"TalonLoadScreen_3.dds",
					"talon_silverdragon_TX_CM.dds",
					"Talon_silverdragon.skl",
					"Talon_silverdragon.skn"
				},
                Image = LoLPath + imgPath + "Talon_3.jpg",
                Background = LoLPath + imgPath + "Talon_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Talon_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"talon_blade_04.sco",
					"talon_blades_02.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("刺客信条");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("血色精锐");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("银龙裁决")
            {
                Files = 
				{
					"talon_dragon_blade.sco",
					"talon_dragon_blade.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("T-塔里克·宝石骑士", "Taric")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"TaricLoadScreen.dds",
					"GemKnight.dds",
					"Taric.skl",
					"Taric.skn",
					"animations\\taric_run.anm",
					"animations\\taric_taunt.anm"
				},
                Image = LoLPath + imgPath + "Taric_0.jpg",
                Background = LoLPath + imgPath + "Taric_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("绿水晶光辉")
            {
                Files = 
				{
					"TaricLoadScreen_1.dds",
					"GemKnight_emerald.dds"
				},
                Image = LoLPath + imgPath + "Taric_1.jpg",
                Background = LoLPath + imgPath + "Taric_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("紫水晶意志")
            {
                Files = 
				{
					"TaricLoadScreen_2.dds",
					"GemKnight_pink.dds",
					"Taric_fifthage.skl",
					"Taric_fifthage.skn"
				},
                Image = LoLPath + imgPath + "Taric_2.jpg",
                Background = LoLPath + imgPath + "Taric_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("血精石诅咒")
            {
                Files = 
				{
					"TaricLoadScreen_3.dds",
					"taric_dreadknight_TX_CM.dds",
					"Taric_dreadknight.skl",
					"Taric_dreadknight.skn",
					"animations\\taric_dreadknight_run.anm",
					"animations\\taric_dreadknight_taunt.anm"
				},
                Image = LoLPath + imgPath + "Taric_3.jpg",
                Background = LoLPath + imgPath + "Taric_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("T-提莫·迅捷斥候", "Teemo")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"teemoLoadScreen.dds",
					"Teemo.dds",
					"Teemo.skl",
					"Teemo.skn",
					"Animations\\Teemo_Run.anm",
					"Animations\\Teemo_Attack1.anm",
					"Animations\\Teemo_Idle1.anm",
					"Animations\\Teemo_Laugh.anm",
					"Animations\\Teemo_Attack2.anm",
					"Animations\\teemo_channel.anm",
					"Animations\\Teemo_channel_windup.anm",
					"Animations\\Teemo_Dance.anm",
					"Animations\\Teemo_Death.anm",
					"Animations\\Teemo_Idle2.anm",
					"Animations\\Teemo_Laugh.anm",
					"Animations\\teemo_spell3.anm",
					"Animations\\teemo_spell4.anm",
					"Animations\\Teemo_Taunt.anm"
				},
                Image = LoLPath + imgPath + "Teemo_0.jpg",
                Background = LoLPath + imgPath + "Teemo_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("圣诞开心鬼")
            {
                Files = 
				{
					"teemoLoadScreen_1.dds",
					"Teemo_happyelf.dds",
					"teemo_happyelf.skl",
					"teemo_happyelf.skn"
				},
                Image = LoLPath + imgPath + "Teemo_1.jpg",
                Background = LoLPath + imgPath + "Teemo_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("军情五处")
            {
                Files = 
				{
					"teemoLoadScreen_2.dds",
					"Teemo_recon.dds"
				},
                Image = LoLPath + imgPath + "Teemo_2.jpg",
                Background = LoLPath + imgPath + "Teemo_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("密林猎手")
            {
                Files = 
				{
					"teemoLoadScreen_3.dds",
					"Teemo_badger.dds"
				},
                Image = LoLPath + imgPath + "Teemo_3.jpg",
                Background = LoLPath + imgPath + "Teemo_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("提莫:'约德尔人的一大步'⊙特效")
            {
                Files = 
				{
					"teemoLoadScreen_4.dds",
					"teemo_astronaut_TX_CM.dds",
					"teemo_astronaut.skl",
					"teemo_astronaut.skn",
					"Animations\\Teemo_Astronaut_run.anm",
					"Animations\\Teemo_Astronaut_attack1.anm",
					"Animations\\Teemo_Astronaut_idle1.anm",
					"Animations\\Teemo_Astronaut_laugh.anm",
					"Animations\\Teemo_Astronaut_attack1.anm"
				},
                Image = LoLPath + imgPath + "Teemo_4.jpg",
                Background = LoLPath + imgPath + "Teemo_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("兔宝宝⊙特效")
            {
                Files = 
				{
					"teemoLoadScreen_5.dds",
					"teemo_easterbunny_TX_CM.dds",
					"Teemo_easterbunny.skl",
					"Teemo_easterbunny.skn",
					"Animations\\Teemo_Easterbunny_run.anm"
				},
                Image = LoLPath + imgPath + "Teemo_5.jpg",
                Background = LoLPath + imgPath + "Teemo_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("约德尔国队长⊙特效")
            {
                Files = 
				{
					"TeemoLoadScreen_6.dds",
					"teemo_super_TX_CM.dds",
					"teemo_super.skl",
					"teemo_super.skn",
					"Animations\\teemo_super_run_fly.anm",
					"Animations\\teemo_super_attack1.anm",
					"Animations\\teemo_super_idle1.anm",
					"Animations\\teemo_super_laugh.anm",
					"Animations\\teemo_super_attack2.anm",
					"Animations\\Teemo_super_channel.anm",
					"Animations\\Teemo_super_channel_windup.anm",
					"Animations\\teemo_super_dance.anm",
					"Animations\\teemo_super_death.anm",
					"Animations\\teemo_super_idle2.anm",
					"Animations\\teemo_super_laugh.anm",
					"Animations\\teemo_super_spell3.anm",
					"Animations\\teemo_super_spell4.anm",
					"Animations\\teemo_super_taunt.anm"
				},
                Image = LoLPath + imgPath + "Teemo_6.jpg",
                Background = LoLPath + imgPath + "Teemo_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("熊猫⊙特效")
            {
                Files = 
				{
					"TeemoLoadScreen_7.dds",
					"teemo_panda_TX_CM.dds",
					"teemo_panda.skl",
					"teemo_panda.skn"
				},
                Image = LoLPath + imgPath + "Teemo_7.jpg",
                Background = LoLPath + imgPath + "Teemo_Splash_7.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Teemo Mushroom", "TeemoMushroom");
            skin = new Skin("经典")
            {
                Files = 
				{
					"MushroomPatch02.dds",
					"BantamTrap.skl",
					"BantamTrap.skn",
					"Animations\\BantamTrap_death.anm",
					"Animations\\BantamTrap_idle.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("圣诞开心鬼");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("军情五处");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("密林猎手");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("提莫:'约德尔人的一大步'")
            {
                Files = 
				{
					"teemo_trap_astronaut_TX_CM.dds",
					"SatelliteTrap.skl",
					"SatelliteTrap.skn",
					"Animations\\SatelliteTrap_death.anm",
					"Animations\\SatelliteTrap_idle1.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("兔宝宝")
            {
                Files = 
				{
					"trap_easterbunny_PET_TX_CM_v01.dds",
					"EasterTrap.skl",
					"EasterTrap.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("约德尔国队长")
            {
                Files = 
				{
					"teemo_superhero_PET_TX_CM_v01.dds",
					"SuperTrap.skl",
					"SuperTrap.skn",
					"Animations\\supertrap_death.anm",
					"Animations\\supertrap_idle1.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("熊猫")
            {
                Files = 
				{
					"teemo_panda_TX_CM.dds",
					"teemo_panda_trap.skl",
					"teemo_panda_trap.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("T-锤石·魂锁典狱长", "Thresh")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"Skins\\Base\\ThreshLoadScreen.dds",
					"Skins\\Base\\Thresh_Base_TX_CM.dds",
					"Skins\\Base\\Thresh.skl",
					"Skins\\Base\\Thresh.skn",
					"Skins\\Base\\Thresh.manifest",
					"Skins\\Base\\Thresh.blnd"
				},
                Image = LoLPath + imgPath + "Thresh_0.jpg",
                Background = LoLPath + imgPath + "Thresh_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("深渊恐惧")
            {
                Files = 
				{
					"Skins\\Skin01\\ThreshLoadScreen_1.dds",
					"Skins\\Skin01\\Thresh_UnderSea_TX_CM.dds",
					"Skins\\Skin01\\Thresh_Undersea.skl",
					"Skins\\Skin01\\Thresh_Undersea.skn",
					"Skins\\Skin01\\ThreshUndersea.manifest",
					"Skins\\Skin01\\ThreshUndersea.blnd"
				},
                Image = LoLPath + imgPath + "Thresh_1.jpg",
                Background = LoLPath + imgPath + "Thresh_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("T-崔斯塔娜·麦林炮手", "Tristana")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"tristanaLoadScreen.dds",
					"Tristana.dds",
					"Tristana.skl",
					"Tristana.skn"
				},
                Image = LoLPath + imgPath + "Tristana_0.jpg",
                Background = LoLPath + imgPath + "Tristana_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("粉色萝莉")
            {
                Files = 
				{
					"tristanaLoadScreen_1.dds",
					"TristanaPink_Diffuse.dds"
				},
                Image = LoLPath + imgPath + "Tristana_1.jpg",
                Background = LoLPath + imgPath + "Tristana_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("圣诞精灵")
            {
                Files = 
				{
					"tristanaLoadScreen_2.dds",
					"Tristana_earnestelf.dds",
					"Tristana_earnestelf.skl",
					"Tristana_earnestelf.skn"
				},
                Image = LoLPath + imgPath + "Tristana_2.jpg",
                Background = LoLPath + imgPath + "Tristana_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("烈焰雄心")
            {
                Files = 
				{
					"tristanaLoadScreen_3.dds",
					"Tristana_Firefighter_TX_CM.dds",
					"Tristana_firefighter.skl",
					"Tristana_firefighter.skn"
				},
                Image = LoLPath + imgPath + "Tristana_3.jpg",
                Background = LoLPath + imgPath + "Tristana_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("游击队员")
            {
                Files = 
				{
					"tristanaLoadScreen_4.dds",
					"tristana_machinegun_TX_CM.dds",
					"tristana_machinegun.skl",
					"tristana_machinegun.skn"
				},
                Image = LoLPath + imgPath + "Tristana_4.jpg",
                Background = LoLPath + imgPath + "Tristana_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("约德尔海盗团")
            {
                Files = 
				{
					"tristanaLoadScreen_5.dds",
					"tristana_scurvydog_TX_CM.dds",
					"tristana_scurvydog.skl",
					"tristana_scurvydog.skn"
				},
                Image = LoLPath + imgPath + "Tristana_5.jpg",
                Background = LoLPath + imgPath + "Tristana_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("火箭达人⊙特效")
            {
                Files = 
				{
					"TristanaLoadScreen_6.dds",
					"tristana_Rocket_TX_CM.dds",
					"tristana_rocket.skl",
					"tristana_rocket.skn"
				},
                Image = LoLPath + imgPath + "Tristana_6.jpg",
                Background = LoLPath + imgPath + "Tristana_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Tristana_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"sphere.sco",
					"cannonballtex.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("粉色萝莉");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("圣诞精灵");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("烈焰雄心");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("游击队员");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("约德尔海盗团");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("火箭达人")
            {
                Files = 
				{
					"Trist_Rocket.sco",
					"trist_rocket_texture.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("T-特朗德尔·诅咒巨魔", "Trundle")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"TrundleLoadScreen.dds",
					"Trundle_base_TX_CM.dds",
					"Trundle.skl",
					"Trundle.skn"
				},
                Image = LoLPath + imgPath + "Trundle_0.jpg",
                Background = LoLPath + imgPath + "Trundle_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("里尔击球手")
            {
                Files = 
				{
					"TrundleLoadScreen_1.dds",
					"trundle_baseball_TX_CM.dds",
					"Trundle_baseball.skl",
					"Trundle_baseball.skn"
				},
                Image = LoLPath + imgPath + "Trundle_1.jpg",
                Background = LoLPath + imgPath + "Trundle_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("垃圾场")
            {
                Files = 
				{
					"TrundleLoadScreen_2.dds",
					"trundle_junkyard_TX_CM.dds",
					"Trundle_junkyard.skl",
					"Trundle_junkyard.skn"
				},
                Image = LoLPath + imgPath + "Trundle_2.jpg",
                Background = LoLPath + imgPath + "Trundle_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("T-泰达米尔·蛮族之王", "Tryndamere")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"TryndamereLoadScreen.dds",
					"tryndamere_base2011_TX_CM.dds",
					"Tryndamere.skl",
					"Tryndamere.skn",
					"Animations\\tryndamere_attack1.anm",
					"Animations\\tryndamere_attack2.anm",
					"Animations\\tryndamere_crit.anm",
					"Animations\\tryndamere_dance.anm",
					"Animations\\tryndamere_death.anm",
					"Animations\\tryndamere_idle1.anm",
					"Animations\\tryndamere_idle2.anm",
					"Animations\\tryndamere_idle3.anm",
					"Animations\\tryndamere_idle4.anm",
					"Animations\\tryndamere_joke.anm",
					"Animations\\tryndamere_laugh.anm",
					"Animations\\tryndamere_run.anm",
					"Animations\\tryndamere_run_rage.anm",
					"Animations\\tryndamere_spell1.anm",
					"Animations\\tryndamere_spell2.anm",
					"Animations\\tryndamere_spell3.anm",
					"Animations\\tryndamere_spell4.anm",
					"Animations\\tryndamere_taunt.anm"
				},
                Image = LoLPath + imgPath + "Tryndamere_0.jpg",
                Background = LoLPath + imgPath + "Tryndamere_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("勇敢的心")
            {
                Files = 
				{
					"TryndamereLoadScreen_1.dds",
					"DarkChampion_Highland.dds",
					"Tryndamere_Highland.skl",
					"Tryndamere_Highland.skn"
				},
                Image = LoLPath + imgPath + "Tryndamere_1.jpg",
                Background = LoLPath + imgPath + "Tryndamere_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("国王")
            {
                Files = 
				{
					"TryndamereLoadScreen_2.dds",
					"tryndamere_king_TX_CM_v01.dds",
					"Tryndamere_King.skl",
					"Tryndamere_King.skn"
				},
                Image = LoLPath + imgPath + "Tryndamere_2.jpg",
                Background = LoLPath + imgPath + "Tryndamere_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("诸神的黄昏")
            {
                Files = 
				{
					"TryndamereLoadScreen_3.dds",
					"tryndamere_viking_TX_CM.dds",
					"Tryndamere_Viking.skl",
					"Tryndamere_Viking.skn"
				},
                Image = LoLPath + imgPath + "Tryndamere_3.jpg",
                Background = LoLPath + imgPath + "Tryndamere_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("恶魔之刃⊙特效")
            {
                Files = 
				{
					"TryndamereLoadScreen_4.dds",
					"tryndamere_demonsword_TX_CM.dds",
					"Tryndamere_Demonsword.skl",
					"Tryndamere_Demonsword.skn",
					"Animations\\tryndamere_demonsword_attack1.anm",
					"Animations\\tryndamere_demonsword_attack2.anm",
					"Animations\\tryndamere_demonsword_crit.anm",
					"Animations\\tryndamere_demonsword_dance.anm",
					"Animations\\tryndamere_demonsword_death.anm",
					"Animations\\tryndamere_demonsword_idle1.anm",
					"Animations\\tryndamere_demonsword_idle2.anm",
					"Animations\\tryndamere_demonsword_idle3.anm",
					"Animations\\tryndamere_demonsword_idle4.anm",
					"Animations\\tryndamere_demonsword_joke.anm",
					"Animations\\tryndamere_demonsword_laugh.anm",
					"Animations\\tryndamere_demonsword_run.anm",
					"Animations\\tryndamere_demonsword_run_rage.anm",
					"Animations\\tryndamere_demonsword_spell1.anm",
					"Animations\\tryndamere_demonsword_spell2.anm",
					"Animations\\tryndamere_demonsword_spell3.anm",
					"Animations\\tryndamere_demonsword_spell4.anm",
					"Animations\\tryndamere_demonsword_taunt.anm"
				},
                Image = LoLPath + imgPath + "Tryndamere_4.jpg",
                Background = LoLPath + imgPath + "Tryndamere_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("苏丹国王⊙特效")
            {
                Files = 
				{
					"TryndamereLoadScreen_5.dds",
					"tryndamere_sultan_TX_CM.dds",
					"tryndamere_sultan.skl",
					"tryndamere_sultan.skn",
					"Animations\\tryndamere_Sultan_attack1.anm",
					"Animations\\tryndamere_Sultan_attack2.anm",
					"Animations\\tryndamere_Sultan_crit.anm",
					"Animations\\tryndamere_Sultan_Dance.anm",
					"Animations\\tryndamere_sultan_death.anm",
					"Animations\\tryndamere_Sultan_Idle1.anm",
					"Animations\\tryndamere_Sultan_Idle1_Windup.anm",
					"Animations\\tryndamere_Sultan_Idle3.anm",
					"Animations\\tryndamere_Sultan_Idle4.anm",
					"Animations\\tryndamere_Sultan_Joke.anm",
					"Animations\\tryndamere_Sultan_Laugh.anm",
					"Animations\\tryndamere_Sultan_run.anm",
					"Animations\\tryndamere_Sultan_Run_Rage.anm",
					"Animations\\tryndamere_demonsword_spell1.anm",
					"Animations\\tryndamere_Sultan_Spell2.anm",
					"Animations\\tryndamere_Sultan_Spell3_alt.anm",
					"Animations\\tryndamere_demonsword_spell4.anm",
					"Animations\\tryndamere_Sultan_Taunt.anm"
				},
                Image = LoLPath + imgPath + "Tryndamere_5.jpg",
                Background = LoLPath + imgPath + "Tryndamere_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Talon_Particle", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"",
					"",
					"",
					"",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("勇敢的心")
            {
                Files = 
				{
					"",
					"",
					"",
					"",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("国王")
            {
                Files = 
				{
					"",
					"",
					"",
					"",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("诸神的黄昏")
            {
                Files = 
				{
					"",
					"",
					"",
					"",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("恶魔之刃")
            {
                Files = 
				{
					"tryndamere_demonsword_souls_01.dds",
					"tryndamere_demonsword_glow.dds",
					"tryndamere_demonsword_bloodlust_choas1.sco",
					"tryndamere_demonsword_spiral_02.sco",
					"tryndamere_demonsword_bloodlust_choas1.sco"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("苏丹国王")
            {
                Files = 
				{
					"tryndamere_Sultan_critimpact.dds",
					"tryndamere_Sultan_slash.dds",
					"tryndamere_Sultan_swordspin.dds",
					"tryndamere_sultan_TX_CM.dds",
					"",
					""
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("T-崔斯特·卡牌大师", "TwistedFate")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"TwistedFateLoadScreen.dds",
					"Twistedfate_base_2012_CM.dds",
					"TwistedFate2012.skl",
					"TwistedFate2012.skn",
					"animations\\twistedfate_idle2.anm",
					"animations\\twistedfate_run.anm"
				},
                Image = LoLPath + imgPath + "TwistedFate_0.jpg",
                Background = LoLPath + imgPath + "TwistedFate_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("蓝色忧郁")
            {
                Files = 
				{
					"TwistedFateLoadScreen_1.dds",
					"twistedfate_pax_TX_CM.dds",
					"twistedfate_pax.skl",
					"twistedfate_pax.skn"
				},
                Image = LoLPath + imgPath + "TwistedFate_1.jpg",
                Background = LoLPath + imgPath + "TwistedFate_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("红桃杰克")
            {
                Files = 
				{
					"TwistedFateLoadScreen_2.dds",
					"twistedfate_Jackofhearts_TX_CM.dds",
					"twistedfate_jackofhearts.skl",
					"twistedfate_jackofhearts.skn"
				},
                Image = LoLPath + imgPath + "TwistedFate_2.jpg",
                Background = LoLPath + imgPath + "TwistedFate_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("魔幻卡牌")
            {
                Files = 
				{
					"TwistedFateLoadScreen_3.dds",
					"CardMaster_swanky.dds",
					"twistedfate_magnificent.skl",
					"twistedfate_magnificent.skn"
				},
                Image = LoLPath + imgPath + "TwistedFate_3.jpg",
                Background = LoLPath + imgPath + "TwistedFate_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("探戈灵魂")
            {
                Files = 
				{
					"TwistedFateLoadScreen_4.dds",
					"twistedfate_tango_TX_CM.dds",
					"twistedfate_tango.skl",
					"twistedfate_tango.skn",
					"animations\\twistedfate_Tango_Idle2.anm",
					"animations\\twistedfate_Tango_run.anm"
				},
                Image = LoLPath + imgPath + "TwistedFate_4.jpg",
                Background = LoLPath + imgPath + "TwistedFate_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("西部牛仔⊙特效")
            {
                Files = 
				{
					"TwistedFateLoadScreen_5.dds",
					"twistedfate_cowboy_TX_CM.dds",
					"twistedfate_cowboy.skl",
					"twistedfate_cowboy.skn",
					"animations\\twistedfate_idle2.anm",
					"animations\\twistedfate_Cowboy_run.anm"
				},
                Image = LoLPath + imgPath + "TwistedFate_5.jpg",
                Background = LoLPath + imgPath + "TwistedFate_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("皇家火枪手")
            {
                Files = 
				{
					"TwistedFateLoadScreen_6.dds",
					"twistedfate_musketeer_TX_CM.dds",
					"twistedfate_musketeer.skl",
					"twistedfate_musketeer.skn",
					"animations\\twistedfate_musketeer_idle2.anm"
				},
                Image = LoLPath + imgPath + "TwistedFate_6.jpg",
                Background = LoLPath + imgPath + "TwistedFate_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("地底世界")
            {
                Files = 
				{
					"TwistedFateLoadScreen_7.dds",
					"TwistedFate_underworld_TX_CM.dds",
					"TwistedFate_underworld.skl",
					"TwistedFate_underworld.skn",
					"animations\\twistedfate_Underworld_Idle2.anm"
				},
                Image = LoLPath + imgPath + "TwistedFate_7.jpg",
                Background = LoLPath + imgPath + "TwistedFate_Splash_7.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("TwistedFateParticles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"CardmasterCard.dds",
					"playingcard.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("蓝色忧郁");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("红桃杰克");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("魔幻卡牌");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("探戈灵魂");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("西部牛仔")
            {
                Files = 
				{
					"CardmasterCard_cowboy.dds",
					"twisted_fate_cowboy_playingcard.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("皇家火枪手");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("地底世界");
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("T-图奇·瘟疫之源", "Twitch")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"twitchLoadScreen.dds",
					"twitch.dds",
					"Twitch.skl",
					"Twitch.skn"
				},
                Image = LoLPath + imgPath + "Twitch_0.jpg",
                Background = LoLPath + imgPath + "Twitch_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("首领")
            {
                Files = 
				{
					"twitchLoadScreen_1.dds",
					"twitch_kingpin.dds"
				},
                Image = LoLPath + imgPath + "Twitch_1.jpg",
                Background = LoLPath + imgPath + "Twitch_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("北风冻原")
            {
                Files = 
				{
					"twitchLoadScreen_2.dds",
					"twitch_germany.dds"
				},
                Image = LoLPath + imgPath + "Twitch_2.jpg",
                Background = LoLPath + imgPath + "Twitch_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("都铎王朝")
            {
                Files = 
				{
					"twitchLoadScreen_3.dds",
					"twitch_mediv.dds",
					"twitch_mediv.skl",
					"twitch_mediv.skn"
				},
                Image = LoLPath + imgPath + "Twitch_3.jpg",
                Background = LoLPath + imgPath + "Twitch_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("黑金诱惑")
            {
                Files = 
				{
					"twitchLoadScreen_4.dds",
					"twitch_gangster_TX_CM.dds",
					"twitch_gangster.skl",
					"twitch_gangster.skn"
				},
                Image = LoLPath + imgPath + "Twitch_4.jpg",
                Background = LoLPath + imgPath + "Twitch_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("横行霸道")
            {
                Files = 
				{
					"twitchLoadScreen_5.dds",
					"Twitch_Punk_TX_CM.dds",
					"Twitch_punk.skl",
					"Twitch_punk.skn"
				},
                Image = LoLPath + imgPath + "Twitch_5.jpg",
                Background = LoLPath + imgPath + "Twitch_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("U-乌迪尔·野兽之灵", "Udyr")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"UdyrLoadScreen.dds",
					"udyr.dds",
					"Udyr.skl",
					"Udyr.skn",
					"Animations\\Udyr_taunt.anm",
					"Animations\\Udyr_Dance.anm",
					"Animations\\udyr_idle1.anm",
					"Animations\\Udyr_laugh.anm",
					"Animations\\udyr_bear_run.anm",
					"Animations\\udyr_run.anm"
				},
                Image = LoLPath + imgPath + "Udyr_0.jpg",
                Background = LoLPath + imgPath + "Udyr_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("武力全开⊙特效")
            {
                Files = 
				{
					"UdyrLoadScreen_1.dds",
					"udyr_orange_gi_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Udyr_1.jpg",
                Background = LoLPath + imgPath + "Udyr_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("四神之力")
            {
                Files = 
				{
					"UdyrLoadScreen_2.dds",
					"udyr_primal_bear_TX_CM.dds",
					"Udyr_primal_bear.skl",
					"Udyr_primal_bear.skn",
					"Animations\\udyr_primal_general_taunt.anm",
					"Animations\\udyr_primal_general_dance.anm",
					"Animations\\udyr_primal_general_idle.anm",
					"Animations\\udyr_primal_general_laugh.anm",
					"Animations\\udyr_primal_bear_run.anm",
					"Animations\\udyr_primal_general_run.anm"
				},
                Image = LoLPath + imgPath + "Udyr_2.jpg",
                Background = LoLPath + imgPath + "Udyr_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("UdyrPhoenix", "UdyrPhoenix");
            skin = new Skin("经典")
            {
                Files = 
				{
					"udyr_phoenix_pelt.dds",
					"Udyr.skl",
					"Udyr.skn",
					"Animations\\udyr_phoenix_run.anm",
					"Animations\\Udyr_taunt.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("武力全开");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("四神之力")
            {
                Files = 
				{
					"udyr_primal_phoenix_TX_CM.dds|DATA\\Particles\\",
					"Udyr_primal_phoenix.skl",
					"Udyr_primal_phoenix.skn",
					"Animations\\udyr_primal_phoenix_run.anm",
					"Animations\\udyr_primal_general_taunt.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("UdyrTiger", "UdyrTiger");
            skin = new Skin("经典")
            {
                Files = 
				{
					"udyr_tiger_pelt.dds",
					"Udyr.skl",
					"Udyr.skn",
					"Animations\\udyr_tiger_idle1.anm",
					"Animations\\Udyr_laugh.anm",
					"Animations\\udyr_tiger_run.anm",
					"Animations\\Udyr_taunt.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("武力全开");
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("四神之力")
            {
                Files = 
				{
					"udyr_primal_tiger_TX_CM.dds|DATA\\Particles\\",
					"Udyr_primal_tiger.skl",
					"Udyr_primal_tiger.skn",
					"Animations\\udyr_primal_tiger_idle.anm",
					"Animations\\udyr_primal_general_laugh.anm",
					"Animations\\udyr_primal_tiger_run.anm",
					"Animations\\udyr_primal_general_taunt.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary.Secondary = new Champion("UdyrTurtle", "UdyrTurtle");
            skin = new Skin("经典")
            {
                Files = 
				{
					"udyr_turtle_pelt.dds",
					"Udyr.skl",
					"Udyr.skn",
					"Animations\\udyr_turtle_attack1.anm",
					"Animations\\udyr_turtle_idle1.anm",
					"Animations\\Udyr_laugh.anm",
					"Animations\\udyr_turtle_run.anm",
					"Animations\\Udyr_taunt.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("武力全开");
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("四神之力")
            {
                Files = 
				{
					"udyr_primal_turtle_TX_CM.dds|DATA\\Particles\\",
					"Udyr_primal_turtle.skl",
					"Udyr_primal_turtle.skn",
					"Animations\\udyr_primal_turtle_attack.anm",
					"Animations\\udyr_primal_turtle_idle.anm",
					"Animations\\udyr_primal_general_laugh.anm",
					"Animations\\udyr_primal_turtle_run.anm",
					"Animations\\udyr_primal_general_taunt.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("Unused");
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary.Secondary.Secondary = new Champion("UdyrParticles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"udyr_turtle_pelt.dds",
					"udyr_tiger_pelt.dds",
					"udyr_phoenix_pelt.dds"
				}
            };
            champion.Secondary.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("武力全开")
            {
                Files = 
				{
					"udyr_turtle_pelt_bb.dds",
					"udyr_tiger_pelt_bb.dds",
					"udyr_phoenix_pelt_bb.dds"
				}
            };
            champion.Secondary.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("四神之力");
            champion.Secondary.Secondary.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("U-厄加特·首领之傲", "Urgot")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"urgotLoadScreen.dds",
					"urgot_base_TX_CM.dds",
					"Urgot.skl",
					"Urgot.skn",
					"Animations\\Urgot_channel.anm",
					"Animations\\Urgot_channel_windup.anm",
					"Animations\\Urgot_dance.anm",
					"Animations\\Urgot_death.anm",
					"Animations\\Urgot_idle1.anm",
					"Animations\\Urgot_idle2.anm",
					"Animations\\Urgot_idle3.anm",
					"Animations\\Urgot_idle4.anm",
					"Animations\\Urgot_laugh.anm",
					"Animations\\Urgot_spell1.anm",
					"Animations\\Urgot_spell2.anm",
					"Animations\\Urgot_spell3.anm",
					"Animations\\Urgot_spell4_loop.anm",
					"Animations\\Urgot_spell4_winddown.anm",
					"Animations\\Urgot_spell4_windup.anm",
					"Animations\\Urgot_taunt.anm",
					"Animations\\Urgot_run.anm",
					"Animations\\Urgot_attack1.anm",
					"Animations\\Urgot_attack2.anm",
					"Animations\\Urgot_crit.anm"
				},
                Image = LoLPath + imgPath + "Urgot_0.jpg",
                Background = LoLPath + imgPath + "Urgot_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("深渊巨蟹⊙特效")
            {
                Files = 
				{
					"urgotLoadScreen_1.dds",
					"urgot_crab_TX_CM.dds",
					"urgot_crab.skl",
					"urgot_crab.skn",
					"Animations\\Urgot_crab_attack1.anm",
					"Animations\\Urgot_crab_attack2.anm",
					"Animations\\Urgot_crab_channel.anm",
					"Animations\\Urgot_crab_channel_windup.anm",
					"Animations\\Urgot_crab_crit.anm",
					"Animations\\Urgot_crab_idle1.anm",
					"Animations\\Urgot_crab_idle3.anm",
					"Animations\\Urgot_crab_idle4.anm",
					"Animations\\Urgot_crab_run.anm"
				},
                Image = LoLPath + imgPath + "Urgot_1.jpg",
                Background = LoLPath + imgPath + "Urgot_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("电锯狂人⊙特效")
            {
                Files = 
				{
					"UrgotLoadScreen_2.dds",
					"urgot_butcher_TX_CM.dds",
					"urgot_butcher.skl",
					"urgot_butcher.skn"
				},
                Image = LoLPath + imgPath + "Urgot_2.jpg",
                Background = LoLPath + imgPath + "Urgot_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("战地机甲⊙特效")
            {
                Files = 
				{
					"urgotLoadScreen_3.dds",
					"urgot_battlecast_TX_CM.dds",
					"urgot_battlecast.skl",
					"urgot_battlecast.skn",
					"Animations\\urgot_battlecast_Attack1.anm",
					"Animations\\urgot_battlecast_Attack2.anm",
					"Animations\\urgot_battlecast_crit.anm",
					"Animations\\urgot_battlecast_dance.anm",
					"Animations\\urgot_battlecast_death.anm",
					"Animations\\urgot_battlecast_Idle1.anm",
					"Animations\\urgot_battlecast_Idle2.anm",
					"Animations\\urgot_battlecast_Idle3.anm",
					"Animations\\urgot_battlecast_laugh.anm",
					"Animations\\urgot_battlecast_Run.anm",
					"Animations\\urgot_battlecast_spell1.anm",
					"Animations\\urgot_battlecast_spell2.anm",
					"Animations\\urgot_battlecast_spell3.anm",
					"Animations\\urgot_battlecast_spell4_loop.anm",
					"Animations\\urgot_battlecast_spell4_winddown.anm",
					"Animations\\urgot_battlecast_spell4_windup.anm",
					"Animations\\urgot_battlecast_taunt.anm"
				},
                Image = LoLPath + imgPath + "Urgot_3.jpg",
                Background = LoLPath + imgPath + "Urgot_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Urgot_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"UrgotBase.dds",
					"UrgotClawGlow.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("深渊巨蟹")
            {
                Files = 
				{
					"urgot_crab_TX_CM.dds",
					"UrgotClaw_crab.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("电锯狂人")
            {
                Files = 
				{
					"urgot_butcher_TX_CM.dds",
					"UrgotClawButcher_glow.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("战地机甲")
            {
                Files = 
				{
					"urgot_battlecast_TX_CM.dds",
					"urgot_battlecast_canister_glow.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("V-韦鲁斯·惩戒之箭", "Varus")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"VarusLoadScreen.dds",
					"Varus_base_TX_CM.dds",
					"Varus.skl",
					"Varus.skn"
				},
                Image = LoLPath + imgPath + "Varus_0.jpg",
                Background = LoLPath + imgPath + "Varus_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("夜魔水晶⊙特效")
            {
                Files = 
				{
					"VarusLoadScreen_1.dds",
					"Varus_dark_crystal_TX_CM.dds",
					"varus_dark_crystal.skl",
					"varus_dark_crystal.skn"
				},
                Image = LoLPath + imgPath + "Varus_1.jpg",
                Background = LoLPath + imgPath + "Varus_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("苍穹之光⊙特效")
            {
                Files = 
				{
					"VarusLoadScreen_2.dds",
					"Varus_ascended_TX_CM.dds",
					"Varus_ascended.skl",
					"Varus_ascended.skn"
				},
                Image = LoLPath + imgPath + "Varus_2.jpg",
                Background = LoLPath + imgPath + "Varus_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Varus_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"varus_base_red.dds",
					"varus_base_white.dds",
					"varus_arrow_flat_anim.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("夜魔水晶")
            {
                Files = 
				{
					"varus_darkcrystal_red.dds",
					"varus_darkcrystal_white.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("苍穹之光")
            {
                Files = 
				{
					"Varus-darkcrystal-weapon-red.dds",
					"Varus-darkcrystal-weapon-white.dds",
					"varus_arrow_flat_anim_amber.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("V-薇恩·暗夜猎手", "Vayne")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"VayneLoadScreen.dds",
					"vayne_base_TX_CM.dds",
					"Vayne.skl",
					"Vayne.skn",
					"Animations\\Vayne_run.anm"
				},
                Image = LoLPath + imgPath + "Vayne_0.jpg",
                Background = LoLPath + imgPath + "Vayne_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("摩登骇客")
            {
                Files = 
				{
					"VayneLoadScreen_1.dds",
					"vayne_modern_TX_CM.dds",
					"Vayne_modern.skl",
					"Vayne_modern.skn"
				},
                Image = LoLPath + imgPath + "Vayne_1.jpg",
                Background = LoLPath + imgPath + "Vayne_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("猎天使魔女")
            {
                Files = 
				{
					"VayneLoadScreen_2.dds",
					"vayne_victorian_TX_CM.dds",
					"Vayne_victorian.skl",
					"Vayne_victorian.skn"
				},
                Image = LoLPath + imgPath + "Vayne_2.jpg",
                Background = LoLPath + imgPath + "Vayne_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("巨龙追猎者")
            {
                Files = 
				{
					"VayneLoadScreen_3.dds",
					"vayne_dragon_TX_CM.dds",
					"Vayne_dragon.skl",
					"Vayne_dragon.skn"
				},
                Image = LoLPath + imgPath + "Vayne_3.jpg",
                Background = LoLPath + imgPath + "Vayne_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("觅心猎手⊙特效")
            {
                Files = 
				{
					"VayneLoadScreen_4.dds",
					"vayne_valentine_TX_CM.dds",
					"Vayne_valentine.skl",
					"Vayne_valentine.skn",
					"Animations\\vayne_valentine_run.anm"
				},
                Image = LoLPath + imgPath + "Vayne_4.jpg",
                Background = LoLPath + imgPath + "Vayne_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Vayne_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"crossbow_arrow_01.sco",
					"ballista_arrow_01.sco",
					"vayne_props_01.dds",
					"Bats32.dds",
					"Flare-Sun_38.dds",
					"color-bloodfade32.dds",
					"color-rampdown.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("摩登骇客");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("猎天使魔女");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("巨龙追猎者");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("觅心猎手")
            {
                Files = 
				{
					"vayne_valentine_arrow.sco",
					"Vayne_Balista_Valentine.sco",
					"vayne_valentine_particles.dds",
					"Vayne_Valentine_Bats.dds",
					"Flare-Sun_pink.dds",
					"color-AhriSmoke.dds",
					"color-AhriSmoke.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("V-维嘉·邪恶小法师", "Veigar")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"VeigarLoadscreen.dds",
					"Veigar_turnaround_b.dds",
					"Veigar.skl",
					"Veigar.skn",
					"DapperVeigar.manifest"
				},
                Image = LoLPath + imgPath + "Veigar_0.jpg",
                Background = LoLPath + imgPath + "Veigar_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("白魔法师")
            {
                Files = 
				{
					"VeigarLoadscreen_1.dds",
					"RedVeigar.dds",
					"Veigar.skl",
					"Veigar.skn"
				},
                Image = LoLPath + imgPath + "Veigar_1.jpg",
                Background = LoLPath + imgPath + "Veigar_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冰壶选手")
            {
                Files = 
				{
					"VeigarLoadscreen_2.dds",
					"Veigar_curling.dds",
					"Veigar_curling.skl",
					"Veigar_curling.skn"
				},
                Image = LoLPath + imgPath + "Veigar_2.jpg",
                Background = LoLPath + imgPath + "Veigar_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("灰胡子魔法师")
            {
                Files = 
				{
					"VeigarLoadscreen_3.dds",
					"veigar_thegrey_TX_CM.dds",
					"veigar_thegrey.skl",
					"veigar_thegrey.skn"
				},
                Image = LoLPath + imgPath + "Veigar_3.jpg",
                Background = LoLPath + imgPath + "Veigar_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("绿野仙踪⊙特效")
            {
                Files = 
				{
					"VeigarLoadscreen_4.dds",
					"veigar_leprechaun_TX_CM.dds",
					"Veigar_leprechaun.skl",
					"Veigar_leprechaun.skn"
				},
                Image = LoLPath + imgPath + "Veigar_4.jpg",
                Background = LoLPath + imgPath + "Veigar_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("魔导绅士")
            {
                Files = 
				{
					"VeigarLoadscreen_5.dds",
					"veigar_baron_TX_CM.dds",
					"Veigar_baron.skl",
					"Veigar_baron.skn"
				},
                Image = LoLPath + imgPath + "Veigar_5.jpg",
                Background = LoLPath + imgPath + "Veigar_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("穿着正装的恶魔")
            {
                Files = 
				{
					"VeigarLoadScreen_6.dds",
					"Veigar_dapper_TX_CM.dds",
					"veigar_dapper.skl",
					"veigar_dapper.skn"
				},
                Image = LoLPath + imgPath + "Veigar_6.jpg",
                Background = LoLPath + imgPath + "Veigar_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("邪恶圣诞老人")
            {
                Files = 
				{
					"VeigarLoadScreen_7.dds",
					"Veigar_badSanta_TX_CM.dds",
					"veigar_badSanta.skl",
					"veigar_badSanta.skn",
					"BadSantaVeigar.manifest"
				},
                Image = LoLPath + imgPath + "Veigar_7.jpg",
                Background = LoLPath + imgPath + "Veigar_Splash_7.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Veigar_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"permission_ability_indicator_06.dds",
					"meteor-blur.dds",
					"veigar_shadow_bolt_proj.dds",
					"veigar_shadow_bolt_proj_03.dds",
					"veigar_rune_green_06.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("白魔法师");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("冰壶选手");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("灰胡子魔法师");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("绿野仙踪")
            {
                Files = 
				{
					"permission_ability_indicator_shamrock.dds",
					"dark_matter_leprechaun_rainbow.dds",
					"veigar_shadow_bolt_proj_07.dds",
					"veigar_shadow_bolt_proj_08.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("魔导绅士");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("穿着正装的恶魔");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("绿野仙踪")
            {
                Files = 
				{
					"veigar_badSanta_cookie_bits_01.dds",
					"veigar_badSanta_gift_single_purp.dds",
					"veigar_badsanta_tree_ring_props_10.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("V-蔚·皮城执法官", "Vi")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"Skins\\Base\\ViLoadScreen.dds",
					"Skins\\Base\\vi_TX_CM.dds",
					"Skins\\Base\\vi.skl",
					"Skins\\Base\\Vi.skn"
				},
                Image = LoLPath + imgPath + "Vi_0.jpg",
                Background = LoLPath + imgPath + "Vi_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("霓虹杀拳")
            {
                Files = 
				{
					"Skins\\Skin01\\ViLoadScreen_1.dds",
					"Skins\\Skin01\\Vi_Racer_TX_CM.dds",
					"Skins\\Skin01\\Vi_Racer.skl",
					"Skins\\Skin01\\Vi_Racer.skn"
				},
                Image = LoLPath + imgPath + "Vi_1.jpg",
                Background = LoLPath + imgPath + "Vi_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("V-维克多·机械先驱", "Viktor")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"ViktorLoadScreen.dds",
					"viktor_base_TX_CM.dds",
					"Viktor.skl",
					"Viktor.skn"
				},
                Image = LoLPath + imgPath + "Viktor_0.jpg",
                Background = LoLPath + imgPath + "Viktor_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("全金属狂潮")
            {
                Files = 
				{
					"ViktorLoadScreen_1.dds",
					"viktor_full_machine_TX_CM.dds",
					"Viktor_full_machine.skl",
					"Viktor_full_machine.skn"
				},
                Image = LoLPath + imgPath + "Viktor_1.jpg",
                Background = LoLPath + imgPath + "Viktor_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("初号机")
            {
                Files = 
				{
					"ViktorLoadScreen_2.dds",
					"viktor_prototype_TX_CM.dds",
					"Viktor_prototype.skl",
					"Viktor_prototype.skn"
				},
                Image = LoLPath + imgPath + "Viktor_2.jpg",
                Background = LoLPath + imgPath + "Viktor_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Viktor_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"Viktor_FFsegment_base.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("全金属狂潮")
            {
                Files = 
				{
					"Viktor_FFsegment_fullMachine.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("初号机")
            {
                Files = 
				{
					"Viktor_FFsegment_prototype.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("V-弗拉基米尔·猩红收割者", "Vladimir")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"VladimirLoadScreen.dds",
					"vladimir_base_TX_CM.dds",
					"Vladimir.skl",
					"Vladimir.skn",
					"Animations\\vladimir_attack1.anm",
					"Animations\\vladimir_attack2.anm",
					"Animations\\vladimir_channel.anm",
					"Animations\\vladimir_channel_windup.anm",
					"Animations\\vladimir_dance.anm",
					"Animations\\vladimir_death.anm",
					"Animations\\vladimir_idle1.anm",
					"Animations\\vladimir_idle1_underground.anm",
					"Animations\\vladimir_idle2.anm",
					"Animations\\vladimir_idle3.anm",
					"Animations\\vladimir_laugh.anm",
					"Animations\\vladimir_run.anm",
					"Animations\\vladimir_run_underground.anm",
					"Animations\\vladimir_spell1.anm",
					"Animations\\vladimir_spell2.anm",
					"Animations\\vladimir_spell2_down.anm",
					"Animations\\vladimir_spell2_up.anm",
					"Animations\\vladimir_spell3.anm",
					"Animations\\vladimir_spell4.anm",
					"Animations\\vladimir_taunt.anm"
				},
                Image = LoLPath + imgPath + "Vladimir_0.jpg",
                Background = LoLPath + imgPath + "Vladimir_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("弗拉基米尔伯爵")
            {
                Files = 
				{
					"VladimirLoadScreen_1.dds",
					"vladimir_dracula_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Vladimir_1.jpg",
                Background = LoLPath + imgPath + "Vladimir_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("弗拉基米尔侯爵")
            {
                Files = 
				{
					"VladimirLoadScreen_2.dds",
					"vladimir_auvergne_TX_CM.dds",
					"vladimir_auvergne.skl",
					"vladimir_auvergne.skn"
				},
                Image = LoLPath + imgPath + "Vladimir_2.jpg",
                Background = LoLPath + imgPath + "Vladimir_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("诺斯费拉图")
            {
                Files = 
				{
					"VladimirLoadScreen_3.dds",
					"vladimir_nosferatu_TX_CM.dds",
					"Vladimir_Nosferatu.skl",
					"Vladimir_Nosferatu.skn"
				},
                Image = LoLPath + imgPath + "Vladimir_3.jpg",
                Background = LoLPath + imgPath + "Vladimir_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("霹雳游侠")
            {
                Files = 
				{
					"VladimirLoadScreen_4.dds",
					"vladimir_biker_TX_CM.dds",
					"vladimir_biker.skl",
					"vladimir_biker.skn"
				},
                Image = LoLPath + imgPath + "Vladimir_4.jpg",
                Background = LoLPath + imgPath + "Vladimir_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("鲜血领主")
            {
                Files = 
				{
					"VladimirLoadScreen_5.dds",
					"vladimir_bloodking_TX_CM.dds",
					"Vladimir_bloodking.skl",
					"Vladimir_bloodking.skn",
					"Animations\\vladimir_BloodKing_attack1.anm",
					"Animations\\vladimir_BloodKing_attack2.anm",
					"Animations\\Vladimir_BloodKing_channel.anm",
					"Animations\\Vladimir_BloodKing_channel_windup.anm",
					"Animations\\Vladimir_BloodKing_dance.anm",
					"Animations\\vladimir_BloodKing_death.anm",
					"Animations\\vladimir_BloodKing_idle1.anm",
					"Animations\\vladimir_BloodKing_idle1_underground.anm",
					"Animations\\vladimir_BloodKing_idle2.anm",
					"Animations\\vladimir_BloodKing_idle3.anm",
					"Animations\\vladimir_BloodKing_laugh.anm",
					"Animations\\vladimir_BloodKing_run.anm",
					"Animations\\vladimir_BloodKing_run_underground.anm",
					"Animations\\vladimir_BloodKing_spell1.anm",
					"Animations\\vladimir_BloodKing_spell2.anm",
					"Animations\\vladimir_BloodKing_spell2_down.anm",
					"Animations\\vladimir_BloodKing_spell2_up.anm",
					"Animations\\vladimir_BloodKing_spell3.anm",
					"Animations\\vladimir_BloodKing_spell4.anm",
					"Animations\\vladimir_BloodKing_taunt.anm"
				},
                Image = LoLPath + imgPath + "Vladimir_5.jpg",
                Background = LoLPath + imgPath + "Vladimir_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("V-沃利贝尔·雷霆咆哮", "Volibear")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"VolibearLoadScreen.dds",
					"volibear_base_TX_CM.dds",
					"Volibear.skl",
					"Volibear.skn"
				},
                Image = LoLPath + imgPath + "Volibear_0.jpg",
                Background = LoLPath + imgPath + "Volibear_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("雷霆领主")
            {
                Files = 
				{
					"VolibearLoadScreen_1.dds",
					"volibear_king_TX_CM.dds",
					"Volibear_king.skl",
					"Volibear_king.skn"
				},
                Image = LoLPath + imgPath + "Volibear_1.jpg",
                Background = LoLPath + imgPath + "Volibear_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("北地风暴")
            {
                Files = 
				{
					"VolibearLoadScreen_2.dds",
					"volibear_artic_TX_CM.dds",
					"Volibear_arctic.skl",
					"Volibear_arctic.skn"
				},
                Image = LoLPath + imgPath + "Volibear_2.jpg",
                Background = LoLPath + imgPath + "Volibear_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("W-沃里克·嗜血猎手", "Warwick")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"WarwickLoadScreen.dds",
					"Wolfman.dds",
					"Warwick.skl",
					"Warwick.skn",
					"Animations\\warwick_laugh.anm",
					"Animations\\warwick_run.anm"
				},
                Image = LoLPath + imgPath + "Warwick_0.jpg",
                Background = LoLPath + imgPath + "Warwick_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("暗影")
            {
                Files = 
				{
					"WarwickLoadScreen_1.dds",
					"Wolfman2White_Diffuse.dds"
				},
                Image = LoLPath + imgPath + "Warwick_1.jpg",
                Background = LoLPath + imgPath + "Warwick_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("披着海牛的狼")
            {
                Files = 
				{
					"WarwickLoadScreen_2.dds",
					"warwick_Urf_TX_CM.dds",
					"warwick_Urf.skl",
					"warwick_Urf.skn"
				},
                Image = LoLPath + imgPath + "Warwick_2.jpg",
                Background = LoLPath + imgPath + "Warwick_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("狼外婆")
            {
                Files = 
				{
					"WarwickLoadScreen_3.dds",
					"warwick_bigbad_TX_CM.dds",
					"warwick_bigbad.skl",
					"warwick_bigbad.skn"
				},
                Image = LoLPath + imgPath + "Warwick_3.jpg",
                Background = LoLPath + imgPath + "Warwick_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冻原猎手")
            {
                Files = 
				{
					"WarwickLoadScreen_4.dds",
					"warwick_tundra_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Warwick_4.jpg",
                Background = LoLPath + imgPath + "Warwick_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("嗜血狂爆")
            {
                Files = 
				{
					"WarwickLoadScreen_5.dds",
					"warwick_savage_TX_CM.dds",
					"Warwick_Savage.skl",
					"Warwick_Savage.skn",
					"Animations\\Warwick_savage_Laugh.anm"
				},
                Image = LoLPath + imgPath + "Warwick_5.jpg",
                Background = LoLPath + imgPath + "Warwick_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("火牙狼人")
            {
                Files = 
				{
					"WarwickLoadScreen_6.dds",
					"warwick_firewolf_TX_CM.dds",
					"warwick_firewolf.skl",
					"warwick_firewolf.skn"
				},
                Image = LoLPath + imgPath + "Warwick_6.jpg",
                Background = LoLPath + imgPath + "Warwick_Splash_6.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("荒野豺狼")
            {
                Files = 
				{
					"WarwickLoadScreen_7.dds",
					"warwick_hyena_TX_CM.dds",
					"warwick_hyena.skl",
					"warwick_hyena.skn",
					"Animations\\warwick_hyena_Laugh.anm",
					"Animations\\warwick_hyena_run.anm"
				},
                Image = LoLPath + imgPath + "Warwick_7.jpg",
                Background = LoLPath + imgPath + "Warwick_Splash_7.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("W-孙悟空·齐天大圣", "MonkeyKing")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"MonkeyKingLoadScreen.dds",
					"monkeyking_base_TX_CM_v02.dds",
					"MonkeyKing.skl",
					"MonkeyKing.skn"
				},
                Image = LoLPath + imgPath + "MonkeyKing_0.jpg",
                Background = LoLPath + imgPath + "MonkeyKing_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("三昧真火")
            {
                Files = 
				{
					"MonkeyKingLoadScreen_1.dds",
					"monkeyking_fire_TX_CM.dds",
					"MonkeyKing_fire.skl",
					"MonkeyKing_fire.skn"
				},
                Image = LoLPath + imgPath + "MonkeyKing_1.jpg",
                Background = LoLPath + imgPath + "MonkeyKing_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("斗战神")
            {
                Files = 
				{
					"MonkeyKingLoadScreen_2.dds",
					"monkeyking_lord_TX_CM.dds",
					"MonkeyKing_lord.skl",
					"MonkeyKing_lord.skn"
				},
                Image = LoLPath + imgPath + "MonkeyKing_2.jpg",
                Background = LoLPath + imgPath + "MonkeyKing_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("定海神针")
            {
                Files = 
				{
					"MonkeyKingLoadScreen_3.dds",
					"monkeyking_dragon_TX_CM.dds",
					"MonkeyKing_dragon.skl",
					"MonkeyKing_dragon.skn"
				},
                Image = LoLPath + imgPath + "MonkeyKing_3.jpg",
                Background = LoLPath + imgPath + "MonkeyKing_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("WukongClone", "MonkeyKingClone");
            skin = new Skin("经典")
            {
                Files = 
				{
					"monkeyking_base_TX_CM_v02.dds",
					"MonkeyKing.skl",
					"MonkeyKing.skn",
					"monkeyking_base_TX_CM_copy.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("三昧真火")
            {
                Files = 
				{
					"monkeyking_fire_TX_CM.dds",
					"MonkeyKing_fire.skl",
					"MonkeyKing_fire.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("斗战神")
            {
                Files = 
				{
					"monkeyking_lord_TX_CM.dds",
					"MonkeyKing_lord.skl",
					"MonkeyKing_lord.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("定海神针")
            {
                Files = 
				{
					"monkeyking_dragon_TX_CM.dds",
					"MonkeyKing_dragon.skl",
					"MonkeyKing_dragon.skn",
					"monkeyking_dragon_TX_CM.dds|DATA\\Particles\\"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("WukongClone", "MonkeyKingFlying");
            skin = new Skin("经典")
            {
                Files = 
				{
					"monkeyking_base_TX_CM_v02.dds",
					"MonkeyKing.skl",
					"MonkeyKing.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("三昧真火")
            {
                Files = 
				{
					"monkeyking_fire_TX_CM.dds",
					"MonkeyKing_fire.skl",
					"MonkeyKing_fire.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("斗战神")
            {
                Files = 
				{
					"monkeyking_lord_TX_CM.dds",
					"MonkeyKing_lord.skl",
					"MonkeyKing_lord.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("定海神针")
            {
                Files = 
				{
					"monkeyking_dragon_TX_CM.dds",
					"MonkeyKing_dragon.skl",
					"MonkeyKing_dragon.skn"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary.Secondary = new Champion("WukongParticles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"monkeyking_base_stone_03.dds",
					"staff_twirl_05.dds",
					"staff_twirl_09.dds",
					"staff_twirl_10.dds",
					"staff_blur_07.dds",
					"staff_blur_single_04.dds",
					"staff_twirl_single.dds",
					"monkeyking_base_TX_CM_copy.dds"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("三昧真火")
            {
                Files = 
				{
					"monkeyking_fire_stone.dds",
					"staff_twirl_05.dds",
					"staff_twirl_09.dds",
					"staff_twirl_10.dds",
					"staff_blur_07.dds",
					"staff_blur_single_04.dds",
					"staff_twirl_single.dds",
					"MonkeyKing_fire_TX_CM_copy.dds"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("斗战神")
            {
                Files = 
				{
					"monkeyking_lord_stone.dds",
					"staff_twirl_05.dds",
					"staff_twirl_09.dds",
					"staff_twirl_10.dds",
					"staff_blur_07.dds",
					"staff_blur_single_04.dds",
					"staff_twirl_single.dds",
					"monkeyking_lord_TX_CM_clone.dds"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("定海神针")
            {
                Files = 
				{
					"monkeyking_base_stone_03.dds",
					"staff_twirl_05_dragon.dds",
					"staff_twirl_09_dragon.dds",
					"staff_twirl_10-dragon.dds",
					"staff_blur_07_dragon.dds",
					"staff_blur_single_04_dragon.dds",
					"staff_twirl_single_dragon.dds"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("X-泽拉斯·远古巫灵", "Xerath")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"XerathLoadscreen.dds",
					"xerath_base_TX_CM.dds",
					"Xerath.skl",
					"Xerath.skn"
				},
                Image = LoLPath + imgPath + "Xerath_0.jpg",
                Background = LoLPath + imgPath + "Xerath_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("符文生物")
            {
                Files = 
				{
					"XerathLoadScreen_1.dds",
					"xerath_rune_TX_CM.dds",
					"Xerath_rune.skl",
					"Xerath_rune.skn"
				},
                Image = LoLPath + imgPath + "Xerath_1.jpg",
                Background = LoLPath + imgPath + "Xerath_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("战地法师")
            {
                Files = 
				{
					"XerathLoadScreen_2.dds",
					"Xerath_iron_TX_CM.dds",
					"Xerath_Iron.skl",
					"Xerath_Iron.skn"
				},
                Image = LoLPath + imgPath + "Xerath_2.jpg",
                Background = LoLPath + imgPath + "Xerath_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("枯萎之壤")
            {
                Files = 
				{
					"XerathLoadScreen_3.dds",
					"xerath_ironforge_TX_CM.dds",
					"xerath_ironforge.skl",
					"xerath_ironforge.skn"
				},
                Image = LoLPath + imgPath + "Xerath_3.jpg",
                Background = LoLPath + imgPath + "Xerath_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("X-赵信·德邦总管", "XinZhao")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"XinZhaoLoadScreen.dds",
					"XenZhao_v2.dds",
					"XinZhao.skl",
					"XinZhao.skn",
					"XinZhaoBase.manifest"
				},
                Image = LoLPath + imgPath + "XinZhao_0.jpg",
                Background = LoLPath + imgPath + "XinZhao_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("特战先锋")
            {
                Files = 
				{
					"XinZhaoLoadScreen_1.dds",
					"xenzhao_commando_TX_CM.dds",
					"xinzhao_commando.skl",
					"xinzhao_commando.skn",
					"CommandoXenZhao.manifest"
				},
                Image = LoLPath + imgPath + "XinZhao_1.jpg",
                Background = LoLPath + imgPath + "XinZhao_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("皇家守卫")
            {
                Files = 
				{
					"XinZhaoLoadScreen_2.dds",
					"xenzhao_imperial_TX_CM.dds",
					"XinZhao.skl",
					"XinZhao.skn",
					"ImperialXenZhao.manifest"
				},
                Image = LoLPath + imgPath + "XinZhao_2.jpg",
                Background = LoLPath + imgPath + "XinZhao_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("绞肉机角斗士")
            {
                Files = 
				{
					"XinZhaoLoadScreen_3.dds",
					"xenzhao_gladiator_TX_CM.dds",
					"xinzhao_gladiator.skl",
					"xinzhao_gladiator.skn",
					"GladiatorXenZhao.manifest"
				},
                Image = LoLPath + imgPath + "XinZhao_3.jpg",
                Background = LoLPath + imgPath + "XinZhao_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("联盟翼骑")
            {
                Files = 
				{
					"XinZhaoLoadScreen_4.dds",
					"xenzhao_wingedhussar_TX_CM.dds",
					"XinZhao_wingedhussar.skl",
					"XinZhao_wingedhussar.skn",
					"WingedHussarXenZhao.manifest"
				},
                Image = LoLPath + imgPath + "XinZhao_4.jpg",
                Background = LoLPath + imgPath + "XinZhao_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("赵云子龙")
            {
                Files = 
				{
					"XinZhaoLoadScreen_5.dds",
					"Xinzhao_zhaoyun_TX_CM.dds",
					"XinZhao_zhaoyun.skl",
					"XinZhao_zhaoyun.skn",
					"ZhaoYunXinZhao.manifest"
				},
                Image = LoLPath + imgPath + "XinZhao_5.jpg",
                Background = LoLPath + imgPath + "XinZhao_Splash_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("X-赵信·德邦总管_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"xen_blade_02.dds",
					"xen_props_01.dds",
					"xen_props_04.dds",
					"xen_shards_01.dds",
					"xen_symbol_06.dds",
					"xenZiou_staff_blur_02.dds",
					"xenZiou_staff_blur_01.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("特战先锋");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("皇家守卫");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("绞肉机角斗士");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("联盟翼骑");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("赵云子龙")
            {
                Files = 
				{
					"xenziou_intimidate.dds",
					"xen_props_02.dds",
					"xen_props_03.dds",
					"xen_shards_01.dds",
					"xen_symbol_06.dds",
					"xenZiou_staff_blur_02.dds",
					"xenZiou_staff_blur_01.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("Y-约里克·掘墓者", "Yorick")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"YorickLoadScreen.dds",
					"yorick_base_CM_TX.dds",
					"Yorick.skl",
					"Yorick.skn",
					"Animations\\yorick_dance.anm"
				},
                Image = LoLPath + imgPath + "Yorick_0.jpg",
                Background = LoLPath + imgPath + "Yorick_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("地狱送葬")
            {
                Files = 
				{
					"YorickLoadScreen_1.dds",
					"yorick_undertaker_TX_CM.dds",
					"Yorick_Undertaker.skl",
					"Yorick_Undertaker.skn"
				},
                Image = LoLPath + imgPath + "Yorick_1.jpg",
                Background = LoLPath + imgPath + "Yorick_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("五杀摇滚贝斯手")
            {
                Files = 
				{
					"YorickLoadScreen_2.dds",
					"Yorick_pentakill_TX_CM.dds",
					"Yorick_Pentakill.skl",
					"Yorick_Pentakill.skn",
					"Animations\\yorick_pentakill_dance.anm"
				},
                Image = LoLPath + imgPath + "Yorick_2.jpg",
                Background = LoLPath + imgPath + "Yorick_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("Z-劫·影流之主", "Zed")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"ZedLoadScreen.dds",
					"Skins\\Base\\Zed_base_TX_CM.dds",
					"Skins\\Base\\Zed.skl",
					"Skins\\Base\\Zed.skn"
				},
                Image = LoLPath + imgPath + "Zed_0.jpg",
                Background = LoLPath + imgPath + "Zed_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("冲击之刃")
            {
                Files = 
				{
					"ZedLoadScreen_1.dds",
					"Skins\\Skin01\\Zed_stormNinja_TX_CM.dds",
					"Skins\\Skin01\\Zed_StormNinja.skl",
					"Skins\\Skin01\\Zed_StormNinja.skn"
				},
                Image = LoLPath + imgPath + "Zed_1.jpg",
                Background = LoLPath + imgPath + "Zed_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("ZedShadow", "ZedShadow");
            skin = new Skin("经典")
            {
                Files = 
				{
					"Skins\\Base\\ZedShadow_base_TX_CM.dds",
					"Skins\\Base\\ZedShadow.skl",
					"Skins\\Base\\ZedShadow.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("冲击之刃")
            {
                Files = 
				{
					"Skins\\Skin01\\ZedShadow_stormNinja_TX_CM.dds",
					"Skins\\Skin01\\ZedShadow_StormNinja.skl",
					"Skins\\Skin01\\ZedShadow_StormNinja.skn"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("Z-吉格斯·爆破鬼才", "Ziggs")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"ZiggsLoadScreen.dds",
					"Ziggs_base_TX_CM.dds",
					"Ziggs.skl",
					"Ziggs.skn"
				},
                Image = LoLPath + imgPath + "Ziggs_0.jpg",
                Background = LoLPath + imgPath + "Ziggs_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("科学狂人⊙特效")
            {
                Files = 
				{
					"ZiggsLoadScreen_1.dds",
					"Ziggs_mad_scientist_TX_CM.dds",
					"Ziggs_madscientist.skl",
					"Ziggs_madscientist.skn"
				},
                Image = LoLPath + imgPath + "Ziggs_1.jpg",
                Background = LoLPath + imgPath + "Ziggs_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("少校")
            {
                Files = 
				{
					"ZiggsLoadScreen_2.dds",
					"Ziggs_general_TX_CM.dds",
					"ziggs_general.skl",
					"ziggs_general.skn"
				},
                Image = LoLPath + imgPath + "Ziggs_2.jpg",
                Background = LoLPath + imgPath + "Ziggs_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("泳池派对")
            {
                Files = 
				{
					"ZiggsLoadScreen_3.dds",
					"ziggs_pool_party_TX_CM.dds",
					"ziggs_pool_party.skl",
					"ziggs_pool_party.skn"
				},
                Image = LoLPath + imgPath + "Ziggs_3.jpg",
                Background = LoLPath + imgPath + "Ziggs_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("血球也能爆炸!")
            {
                Files = 
				{
					"ZiggsLoadScreen_4.dds",
					"ziggs_snowday_TX_CM.dds",
					"ziggs_snowday.skl",
					"ziggs_snowday.skn"
				},
                Image = LoLPath + imgPath + "Ziggs_4.jpg",
                Background = LoLPath + imgPath + "Ziggs_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Ziggs_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"ZiggsBomb.sco",
					"Ziggs_base.dds",
					"color-darksmoke.dds",
					"FlashOrange.dds",
					"OrbGlow.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("科学狂人")
            {
                Files = 
				{
					"ZiggsBomb.sco",
					"Ziggs_base.dds",
					"color-BeakerSmoke.dds",
					"FlashGreen.dds",
					"greenglow.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("少校")
            {
                Files = 
				{
					"Ziggs_GeneralBomb.sco",
					"ziggs_general.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("泳池派对")
            {
                Files = 
				{
					"Ziggs_GeneralBomb.sco",
					"ziggs_general.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("血球也能爆炸!")
            {
                Files = 
				{
					"Ziggs_Skn4_UltBomb.sco",
					"ziggs_skn4_snowballtx.dds",
					"ziggs_icicle_tx.dds",
					"FlashPurple.dds",
					"OrbGlow.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("Z-基兰·时光守护者", "Zilean")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"ZileanLoadScreen.dds",
					"chronokeeper.dds",
					"Zilean.skl",
					"Zilean.skn"
				},
                Image = LoLPath + imgPath + "Zilean_0.jpg",
                Background = LoLPath + imgPath + "Zilean_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("圣诞狂欢")
            {
                Files = 
				{
					"ZileanLoadScreen_1.dds",
					"Chronokeeper_oldst.dds",
					"zilean_christmas.skl",
					"zilean_christmas.skn"
				},
                Image = LoLPath + imgPath + "Zilean_1.jpg",
                Background = LoLPath + imgPath + "Zilean_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("嘻哈精神")
            {
                Files = 
				{
					"ZileanLoadScreen_2.dds",
					"zilean_hippie_TX_CM.dds"
				},
                Image = LoLPath + imgPath + "Zilean_2.jpg",
                Background = LoLPath + imgPath + "Zilean_Splash_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("遗迹守护者⊙特效")
            {
                Files = 
				{
					"ZileanLoadScreen_3.dds",
					"zilean_desert _TX_CM.dds",
					"zilean_desert.skl",
					"zilean_desert.skn"
				},
                Image = LoLPath + imgPath + "Zilean_3.jpg",
                Background = LoLPath + imgPath + "Zilean_Splash_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("时间机器")
            {
                Files = 
				{
					"ZileanLoadScreen_4.dds",
					"zilean_timemachine_TX_CM.dds",
					"zilean_timemachine.skl",
					"zilean_timemachine.skn"
				},
                Image = LoLPath + imgPath + "Zilean_4.jpg",
                Background = LoLPath + imgPath + "Zilean_Splash_4.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Zilean_Particles", particles);
            skin = new Skin("经典")
            {
                Files = 
				{
					"Gear.sco",
					"ChronoGear.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("圣诞狂欢");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("嘻哈精神");
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("遗迹守护者")
            {
                Files = 
				{
					"zilean_desert_rock.sco",
					"zilean_desert _TX_CM.dds"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("时间机器");
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("Z-婕拉·荆棘之兴", "Zyra")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"ZyraLoadScreen.dds",
					"Zyra_base_TX_CM.dds",
					"Zyra_Plants_base_TX_CM.dds",
					"Zyra.skl",
					"Zyra.skn"
				},
                Image = LoLPath + imgPath + "Zyra_0.jpg",
                Background = LoLPath + imgPath + "Zyra_Splash_0.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("燎原野火⊙特效")
            {
                Files = 
				{
					"ZyraLoadScreen_1.dds",
					"Zyra_hellvine_TX_CM.dds",
					"Zyra_Plants_hellvine_TX_CM.dds",
					"Zyra_hellvine.skl",
					"Zyra_hellvine.skn"
				},
                Image = LoLPath + imgPath + "Zyra_1.jpg",
                Background = LoLPath + imgPath + "Zyra_Splash_1.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Z-婕拉·荆棘之兴", "ZyraGraspingPlant");
            champion.New = false;
            skin = new Skin("经典")
            {
                Files = 
				{
					"Zyra_Plant_Thorn.skl",
					"Zyra_Plant_Thorn.skn",
					"Zyra_Plants_base_TX_CM.dds",
					"Animations\\jarvanIV_attack1.anm",
					"Animations\\jarvanIV_death_60fps.anm",
					"Animations\\jarvanIV_idle3.anm",
					"Animations\\Zyra_plant_Thorn_attack1.anm",
					"Animations\\Zyra_plant_Thorn_attack2.anm",
					"Animations\\Zyra_plant_Thorn_death.anm",
					"Animations\\Zyra_plant_Thorn_idle1.anm",
					"Animations\\Zyra_plant_Thorn_idle2.anm",
					"Animations\\Zyra_plant_Thorn_up.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("燎原野火")
            {
                Files = 
				{
					"Zyra_HellvinePlant_Thorn.skl",
					"Zyra_HellvinePlant_Thorn.skn",
					"Zyra_Plants_hellvine_TX_CM.dds",
					"Animations\\jarvanIV_attack1.anm",
					"Animations\\jarvanIV_death_60fps.anm",
					"Animations\\jarvanIV_idle3.anm",
					"Animations\\Zyra_plant_Thorn_attack1.anm",
					"Animations\\Zyra_plant_Thorn_attack2.anm",
					"Animations\\Zyra_plant_Thorn_death.anm",
					"Animations\\Zyra_plant_Thorn_idle1.anm",
					"Animations\\Zyra_plant_Thorn_idle2.anm",
					"Animations\\Zyra_plant_Thorn_up.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary = new Champion("Z-婕拉·荆棘之兴", "ZyraSeed");
            champion.New = false;
            skin = new Skin("经典")
            {
                Files = 
				{
					"Zyra_Plant_Ball.skl",
					"Zyra_Plant_Ball.skn",
					"Zyra_Plants_base_TX_CM.dds",
					"animations\\Zyra_Plant_Ball_death.anm",
					"animations\\Zyra_plant_ball_death3.anm",
					"animations\\Zyra_Plant_Ball_idle1.anm",
					"animations\\ZyraSeed_death2.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("燎原野火")
            {
                Files = 
				{
					"Zyra_Hellvine_Plant_Ball.skl",
					"Zyra_Hellvine_Plant_Ball.skn",
					"Zyra_Plants_hellvine_TX_CM.dds",
					"animations\\Zyra_Plant_Ball_death.anm",
					"animations\\Zyra_plant_ball_death3.anm",
					"animations\\Zyra_Plant_Ball_idle1.anm",
					"animations\\ZyraSeed_death2.anm"
				}
            };
            champion.Secondary.Secondary.Skins.Add(skin);
            champion.Secondary.Secondary.Secondary = new Champion("Z-婕拉·荆棘之兴", "ZyraThornPlant");
            champion.New = false;
            skin = new Skin("经典")
            {
                Files = 
				{
					"Zyra_Plant_Blossom.skl",
					"Zyra_Plant_Blossom.skn",
					"Zyra_Plants_base_TX_CM.dds",
					"Animations\\Zyra_plant_Blossom_attack1.anm",
					"Animations\\Zyra_plant_Blossom_death.anm",
					"Animations\\Zyra_plant_Blossom_idle1.anm",
					"Animations\\Zyra_plant_Blossom_idle2.anm",
					"Animations\\Zyra_plant_Blossom_up.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            skin = new Skin("燎原野火")
            {
                Files = 
				{
					"Zyra_HellvinePlant_Blossom.skl",
					"Zyra_HellvinePlant_Blossom.skn",
					"Zyra_Plants_hellvine_TX_CM.dds",
					"Animations\\Zyra_plant_Blossom_attack1.anm",
					"Animations\\Zyra_plant_Blossom_death.anm",
					"Animations\\Zyra_plant_Blossom_idle1.anm",
					"Animations\\Zyra_plant_Blossom_idle2.anm",
					"Animations\\Zyra_plant_Blossom_up.anm"
				}
            };
            champion.Secondary.Secondary.Secondary.Skins.Add(skin);
            this.List.Add(champion);
            champion = new Champion("Y-眼睛皮肤", "SightWard")
            {
                New = false
            };
            skin = new Skin("经典")
            {
                Files = 
				{
					"SightWard.dds",
					"SightWard.skl",
					"SightWard.skn",
					"Animations.list",
					"Animations\\sightward_idle.anm",
					"Animations\\sightward_death.anm"
				},
                Image = LoLPath + "Air\\assets\\storeImages\\layout\\wards_ico.png",
                Background = LoLPath + "Air\\assets\\storeImages\\layout\\wards_ico.png"
            };
            champion.Skins.Add(skin);
            skin = new Skin("南瓜头蝙蝠")
            {
                Files = 
				{
					"sightward_bat_TX_CM.dds",
					"sightward_bat.skl",
					"sightward_bat.skn",
					"Animations.list",
					"Animations\\sightward_bat_idle.anm",
					"Animations\\sightward_bat_Death.anm"
				},
                Image = LoLPath + "Air\\assets\\storeImages\\content\\ward_skins\\wardskin_1.jpg",
                Background = LoLPath + "Air\\assets\\storeImages\\content\\ward_skins\\wardskin_1.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("幽灵")
            {
                Files = 
				{
					"sightward_ghost_TX_CM.dds",
					"sightward_ghost.skl",
					"sightward_ghost.skn",
					"Animations.list",
					"Animations\\sightward_ghost_idle.anm",
					"Animations\\sightward_ghost_Death.anm"
				},
                Image = LoLPath + "Air\\assets\\storeImages\\content\\ward_skins\\wardskin_2.jpg",
                Background = LoLPath + "Air\\assets\\storeImages\\content\\ward_skins\\wardskin_2.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("蜘蛛寡妇")
            {
                Files = 
				{
					"sightward_spider_TX_CM.dds",
					"sightward_spider.skl",
					"sightward_spider.skn",
					"Animations.list",
					"Animations\\sightward_spider_idle.anm",
					"Animations\\sightward_spider_Death.anm"
				},
                Image = LoLPath + "Air\\assets\\storeImages\\content\\ward_skins\\wardskin_3.jpg",
                Background = LoLPath + "Air\\assets\\storeImages\\content\\ward_skins\\wardskin_3.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("树精")
            {
                Files = 
				{
					"sightward_tree_TX_CM.dds",
					"sightward_tree.skl",
					"sightward_tree.skn",
					"Animations.list",
					"Animations\\sightward_tree_idle.anm",
					"Animations\\sightward_tree_Death.anm"
				},
                Image = LoLPath + "Air\\assets\\storeImages\\content\\ward_skins\\wardskin_4.jpg",
                Background = LoLPath + "Air\\assets\\storeImages\\content\\ward_skins\\wardskin_4.jpg"
            };
            champion.Skins.Add(skin);
            skin = new Skin("墓天使")
            {
                Files = 
				{
					"sightward_stone_TX_CM.dds",
					"sightward_stone.skl",
					"sightward_stone.skn",
					"Animations.list",
					"Animations\\sightward_stone_idle.anm",
					"Animations\\sightward_stone_Death.anm"
				},
                Image = LoLPath + "Air\\assets\\storeImages\\content\\ward_skins\\wardskin_5.jpg",
                Background = LoLPath + "Air\\assets\\storeImages\\content\\ward_skins\\wardskin_5.jpg"
            };
            champion.Skins.Add(skin);
            champion.Secondary = new Champion("Y-眼睛皮肤", "VisionWard");
            champion.New = false;
            skin = new Skin("经典")
            {
                Files = 
				{
					"VisionWard.dds",
					"VisionWard.skl",
					"VisionWard.skn",
					"Animations.list",
					"Animations\\VisionWard_idle.anm",
					"Animations\\VisionWard_death.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("南瓜头蝙蝠")
            {
                Files = 
				{
					"sightward_bat_TX_CM.dds",
					"sightward_bat.skl",
					"sightward_bat.skn",
					"Animations.list",
					"Animations\\sightward_bat_idle.anm",
					"Animations\\sightward_bat_Death.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("幽灵")
            {
                Files = 
				{
					"sightward_ghost_TX_CM.dds",
					"sightward_ghost.skl",
					"sightward_ghost.skn",
					"Animations.list",
					"Animations\\sightward_ghost_idle.anm",
					"Animations\\sightward_ghost_Death.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("蜘蛛寡妇")
            {
                Files = 
				{
					"sightward_spider_TX_CM.dds",
					"sightward_spider.skl",
					"sightward_spider.skn",
					"Animations.list",
					"Animations\\sightward_spider_idle.anm",
					"Animations\\sightward_spider_Death.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("树精")
            {
                Files = 
				{
					"sightward_tree_TX_CM.dds",
					"sightward_tree.skl",
					"sightward_tree.skn",
					"Animations.list",
					"Animations\\sightward_tree_idle.anm",
					"Animations\\sightward_tree_Death.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            skin = new Skin("墓天使")
            {
                Files = 
				{
					"sightward_stone_TX_CM.dds",
					"sightward_stone.skl",
					"sightward_stone.skn",
					"Animations.list",
					"Animations\\sightward_stone_idle.anm",
					"Animations\\sightward_stone_Death.anm"
				}
            };
            champion.Secondary.Skins.Add(skin);
            this.List.Add(champion);
        }
    }

}
