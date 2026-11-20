using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x020020B7 RID: 8375
[bmq("1.2.0.0_Cc_EnterGauntletLockerModelChange", "1.2.0.0", "cc_enterGauntlet", false)]
public sealed class e5c : fg
{
	// Token: 0x0600C7DA RID: 51162 RVA: 0x0046677C File Offset: 0x0046497C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("cc_enterGauntlet");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("5662474d-b5a7-439e-9808-e9d2f04095c9"), aud).ao() as c5x;
				if (c5x != null)
				{
					e4x e4x = c5x.GetAspect<cd0>() as e4x;
					if (e4x != null && e4x.a != "Objects\\Containers\\WeaponShelve")
					{
						e4x.a = "Objects\\Containers\\WeaponShelve";
						e4x.b.X = 2;
						e4x.b.Y = 0;
						c7j c7j = c5x.GetAspect<bim>() as c7j;
						if (c7j != null)
						{
							c7j.a(new int?(3));
							c7j.b(new int?(2));
						}
						c5x.VisualDirection = HorizontalDirection.East;
						c5x.ah();
					}
				}
				c5x c5x2 = new ar7(new Guid("c9b25e11-c8a8-4b69-81b0-ce6012168a1a"), aud).ao() as c5x;
				if (c5x2 != null)
				{
					e4x e4x2 = c5x2.GetAspect<cd0>() as e4x;
					if (e4x2 != null && e4x2.a != "Objects\\Containers\\WeaponShelve")
					{
						e4x2.a = "Objects\\Containers\\WeaponShelve";
						e4x2.b.X = 2;
						e4x2.b.Y = 0;
						c7j c7j2 = c5x2.GetAspect<bim>() as c7j;
						if (c7j2 != null)
						{
							c7j2.a(new int?(3));
							c7j2.b(new int?(2));
						}
						c5x2.VisualDirection = HorizontalDirection.East;
						c5x2.ah();
					}
				}
				c5x c5x3 = new ar7(new Guid("676e4ff4-4f13-4521-b374-d09f397db353"), aud).ao() as c5x;
				if (c5x3 != null)
				{
					c5x3.Location = new Vector3(5f, 1.1f, 0f);
					c5x3.Size = new Vector3(1f, 0.5f, 1f);
					c5x3.VisualDirection = HorizontalDirection.East;
					c5x3.ah();
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
