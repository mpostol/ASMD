//---------------------------------------------------------------------------
//
// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Limited Permissive License.
// See http://www.microsoft.com/resources/sharedsource/licensingbasics/limitedpermissivelicense.mspx
// All other rights reserved.
//
// This file is part of the 3D Tools for Windows Presentation Foundation
// project.  For more information, see:
// 
// http://CodePlex.com/Wiki/View.aspx?ProjectName=3DTools
//
//---------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using _3DTools;

namespace InteractiveViewport3DSample
{
    public class InteractiveCone : InteractiveVisual3D
    {
        public InteractiveCone()
        {
            Geometry = Tessellate();
        }


        internal double DegToRad(double degrees)
        {
            return (degrees / 180.0) * Math.PI;
        }


        internal Point3D GetPosition(double t, double y)
        {
            double r = (1 + y) / 2;
            double x = r * Math.Cos(t);
            double z = r * Math.Sin(t);

            return new Point3D(x, y, z);
        }


        private Vector3D GetNormal(double t, double y)
        {
            double x = 2 * Math.Cos(t);
            double z = 2 * Math.Sin(t);

            return new Vector3D(x, 1, z);
        }
        

        private Point GetTextureCoordinate(double t, double y)
        {
            return new Point(1.0 - t * 1 / (2 * Math.PI), y * -0.5 + 0.5);
        }

        internal MeshGeometry3D Tessellate()
        {
            int tDiv = 32;
            int yDiv = 32;
            double maxTheta = DegToRad(360.0);
            double minY = -1.0;
            double maxY = 1.0;

            double dt = maxTheta / tDiv;
            double dy = (maxY - minY) / yDiv;

            MeshGeometry3D mesh = new MeshGeometry3D();

            for (int yi = 0; yi <= yDiv; yi++)
            {
                double y = minY + yi * dy;

                for (int ti = 0; ti <= tDiv; ti++)
                {
                    double t = ti * dt;

                    mesh.Positions.Add(GetPosition(t, y));
                    mesh.Normals.Add(GetNormal(t, y));
                    mesh.TextureCoordinates.Add(GetTextureCoordinate(t, y));
                }
            }

            for (int yi = 0; yi < yDiv; yi++)
            {
                for (int ti = 0; ti < tDiv; ti++)
                {
                    int x0 = ti;
                    int x1 = (ti + 1);
                    int y0 = yi * (tDiv + 1);
                    int y1 = (yi + 1) * (tDiv + 1);

                    mesh.TriangleIndices.Add(x0 + y0);
                    mesh.TriangleIndices.Add(x0 + y1);
                    mesh.TriangleIndices.Add(x1 + y0);

                    mesh.TriangleIndices.Add(x1 + y0);
                    mesh.TriangleIndices.Add(x0 + y1);
                    mesh.TriangleIndices.Add(x1 + y1);
                }
            }

            mesh.Freeze();
            return mesh;
        }
        
    }    
}
