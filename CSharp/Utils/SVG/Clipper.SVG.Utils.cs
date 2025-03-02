﻿/*******************************************************************************
* Author    :  Angus Johnson                                                   *
* Date      :  3 July 2022                                                     *
* Website   :  http://www.angusj.com                                           *
* Copyright :  Angus Johnson 2010-2022                                         *
* License:                                                                     *
* Use, modification & distribution is subject to Boost Software License Ver 1. *
* http://www.boost.org/LICENSE_1_0.txt                                         *
*******************************************************************************/

using System.Collections.Generic;
using System.IO;

namespace Clipper2Lib
{

  using Paths64 = List<List<Point64>>;
  using PathsD = List<List<PointD>>;

  public static class SvgUtils
  {

    public static void AddCaption(SimpleSvgWriter svg, string caption, int x, int y)
    {
      svg.AddText(caption, x, y, 14);
    }

    public static void AddSubject(SimpleSvgWriter svg, Paths64 paths,
      bool is_closed = true, bool is_joined = true)
    {
      if (!is_closed)
        svg.AddPaths(paths, !is_joined, 0x0, 0xCCB3B3DA, 0.8);
      else
        svg.AddPaths(paths, false, 0x1800009C, 0xCCB3B3DA, 0.8);
    }

    public static void AddClip(SimpleSvgWriter svg, Paths64 paths)
    {
      svg.AddPaths(paths, false, 0x129C0000, 0xCCFFA07A, 0.8);
    }

    public static void AddSolution(SimpleSvgWriter svg, Paths64 paths,
      bool show_coords, bool is_closed = true, bool is_joined = true)
    {
      if (!is_closed)
        svg.AddPaths(paths, !is_joined, 0x0, 0xFF003300, 0.8, show_coords);
      else
        svg.AddPaths(paths, false, 0xFF80ff9C, 0xFF003300, 0.8, show_coords);
    }

    public static void AddSolution(SimpleSvgWriter svg, PathsD paths,
      bool show_coords, bool is_closed = true, bool is_joined = true)
    {
      if (!is_closed)
        svg.AddPaths(paths, !is_joined, 0x0, 0xFF003300, 0.8, show_coords);
      else
        svg.AddPaths(paths, false, 0xFF80ff9C, 0xFF003300, 0.8, show_coords);
    }

    public static void SaveToFile(SimpleSvgWriter svg,
      string filename, FillRule fill_rule,
      int max_width = 0, int max_height = 0, int margin = 0)
    {
      if (File.Exists(filename)) File.Delete(filename);
      svg.FillRule = fill_rule;
      svg.SaveToFile(filename, max_width, max_height, margin);
    }

  }

}
