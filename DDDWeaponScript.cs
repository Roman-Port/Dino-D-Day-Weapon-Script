using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class DDDWeaponScript
    {
        public string Damage { get; set; }
        public string Bullets { get; set; }
        public string CycleTime { get; set; }
        public string CycleTime2 { get; set; }
        public string BulletSpread { get; set; }
        public string PunchAngleX { get; set; }
        public string PunchAngleY { get; set; }
        public string PunchOffset { get; set; }
        public string CanSelectROF { get; set; }

        public string BuiltRightHanded { get; set; }

        public string printname { get; set; }
        public string viewmodel { get; set; }
        public string playermodel { get; set; }
        public string PlayerAnimationExtension { get; set; }

        public string bucket { get; set; }
        public string bucket_position { get; set; }

        public string clip_size { get; set; }
        public string NumClips { get; set; }

        public string primary_ammo { get; set; }
        public string secondary_ammo { get; set; }

        public string weight { get; set; }
        public string item_flags { get; set; }

        public string MuzzleFlashEffect { get; set; }

        public DDDWeaponScript_SoundData SoundData { get; set; }
        /*public DDDWeaponScript_TextureData TextureData { get; set; }
        public DDDWeaponScript_ModelBounds ModelBounds { get; set; }*/
    }

    class DDDWeaponScript_SoundData
    {
        public string reload { get; set; }
        public string empty { get; set; }
        public string single_shot { get; set; }
    }

    class DDDWeaponScript_TextureData
    {
        public DDDWeaponScript_TextureData_Data3d weapon { get; set; }
        public DDDWeaponScript_TextureData_Data3d weapon_s { get; set; }
        public DDDWeaponScript_TextureData_Data3d ammo { get; set; }

        public DDDWeaponScript_TextureData_Data2d crosshair { get; set; }
        public DDDWeaponScript_TextureData_Data2d autoaim { get; set; }
    }

    class DDDWeaponScript_TextureData_Data3d
    {
        public string font { get; set; }
        public string character { get; set; }
    }

    class DDDWeaponScript_TextureData_Data2d
    {
        public string file { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string width { get; set; }
        public string height { get; set; }
    }

    class DDDWeaponScript_ModelBounds
    {
        public DDDWeaponScript_ModelBounds_Area Viewmodel { get; set; }
        public DDDWeaponScript_ModelBounds_Area World { get; set; }
    }

    class DDDWeaponScript_ModelBounds_Area
    {
        public string Mins { get; set; }
        public string Maxs { get; set; }
    }
}
