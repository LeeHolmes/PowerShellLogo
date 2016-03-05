# PowerShellLogo 
PowerShell implementation of the classic 'Logo', and demonstration of hosting the PowerShell Engine.

For more information, see:

- http://www.leeholmes.com/blog/2006/01/14/monad-hosting-an-introduction/
- http://www.leeholmes.com/blog/2006/01/26/msh-logo-our-design-strategy/
- http://www.leeholmes.com/blog/2006/02/08/msh-logo-%e2%80%93-a-gui-disaster/
- http://www.leeholmes.com/blog/2006/02/14/msh-logo-%e2%80%93-allowing-users-to-extend-its-functionality/

Here's an example of a fancy fern done with PowerShell Logo:

```powershell
################################################################################
##
## Draw a fern.
## Warning -- takes about 40 seconds to compute.
##
################################################################################

$turtle.Reset()

function fern($size)
{
   if($size -lt 5) { return }
   
   $turtle.Forward($size / 20)
   $turtle.Left(80)
   fern ($size * 0.3)
   
   $turtle.Right(82)
   $turtle.Forward($size / 20)

   $turtle.Right(80)
   fern ($size * 0.3)

   $turtle.Left(78)
   fern ($size * 0.9)

   $turtle.Left(2)
   $turtle.Backward($size / 20)
   
   $turtle.Left(2)
   $turtle.Backward($size / 20)
}

$turtle.PenUp()
$turtle.Left(90)
$turtle.Forward(50)
$turtle.Left(90)
$turtle.Forward(180)
$turtle.Right(180)
$turtle.PenDown()

fern 440

```
