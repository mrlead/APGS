using ObjParser;
using System.Windows.Media.Media3D;

namespace APGS
{
    class Sword
    {
        public string path_model;

        double x_angle = 0;
        double y_angle = 0;
        double z_angle = 0;
        int proj = 0;
        Matrix3D Zoom = Matrix3D.Identity;
        Matrix3D Loc = Matrix3D.Identity;
        Matrix3D rotate_x = Matrix3D.Identity;
        Matrix3D rotate_y = Matrix3D.Identity;
        Matrix3D rotate_z = Matrix3D.Identity;
        public Obj obj;

        public Sword(string path_model)
        {
            Zoom.M11 = 1;
            Zoom.M22 = 1;
            Zoom.M33 = 1;
            Loc.M11 = 0;
            Loc.M22 = 0;
            Loc.M33 = 0;
            this.path_model = path_model;
            obj = new Obj();
            obj.LoadObj(path_model);
        }
    }
}
