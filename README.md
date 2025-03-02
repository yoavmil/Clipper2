# Clipper2
### A Polygon <a href="https://en.wikipedia.org/wiki/Clipping_(computer_graphics)">Clipping</a> and <a href="https://en.wikipedia.org/wiki/Parallel_curve">Offsetting</a> library (in C++, C# &amp; Delphi)<br>
[![GitHub Actions C++ status](https://github.com/AngusJohnson/Clipper2/actions/workflows/actions_cpp.yml/badge.svg)](https://github.com/AngusJohnson/Clipper2/actions/workflows/actions_cpp.yml)&nbsp;[![C#](https://github.com/AngusJohnson/Clipper2/actions/workflows/actions_csharp.yml/badge.svg)](https://github.com/AngusJohnson/Clipper2/actions/workflows/actions_csharp.yml)&nbsp;[![License](https://img.shields.io/badge/License-Boost_1.0-lightblue.svg)](https://www.boost.org/LICENSE_1_0.txt)
[![documentation](https://user-images.githubusercontent.com/5280692/187832279-b2a43890-da80-4888-95fe-793f092be372.svg)](http://www.angusj.com/clipper2/Docs/Overview.htm)

<b>Clipper2</b> is a major update of my original <a href="https://sourceforge.net/projects/polyclipping/"><b>Clipper</b></a> library which I'm now calling <b>Clipper1</b>.<br> Clipper1 was written over 10 years ago and still works very well, but Clipper2 is better in just about every way.

### Documentation

 <a href="http://www.angusj.com/clipper2/Docs/Overview.htm"><b>Extensive HTML documentation</b></a>
<br><br>

### Examples

<pre>
      //C++
      Paths64 subject, clip, solution;
      subject.push_back(MakePath("100, 50, 10, 79, 65, 2, 65, 98, 10, 21"));
      clip.push_back(MakePath("98, 63, 4, 68, 77, 8, 52, 100, 19, 12"));
      solution = Intersect(subject, clip, FillRule::NonZero);</pre>
<pre>      //C#
      Paths64 subj = new Paths64();
      Paths64 clip = new Paths64();
      subj.Add(Clipper.MakePath(new int[] { 100, 50, 10, 79, 65, 2, 65, 98, 10, 21 }));
      clip.Add(Clipper.MakePath(new int[] { 98, 63, 4, 68, 77, 8, 52, 100, 19, 12 }));
      Paths64 solution = Clipper.Intersect(subj, clip, FillRule.NonZero);</pre>
<pre>      //Delphi
      var 
        subject, clip, solution: TPaths64;
      begin
        SetLength(subject, 1);
        subject[0] := MakePath([100, 50, 10, 79, 65, 2, 65, 98, 10, 21]);
        SetLength(clip, 1);
        clip[0] := MakePath([98, 63, 4, 68, 77, 8, 52, 100, 19, 12]);
        solution := Intersect( subject, clip, frNonZero);</pre>
![clipperB](https://user-images.githubusercontent.com/5280692/178123810-1719a1f5-25c3-4a9e-b419-e575ff056272.svg)
