using System;

// Token: 0x0200115A RID: 4442
public static class kb
{
	// Token: 0x06005F1E RID: 24350 RVA: 0x002854F0 File Offset: 0x002836F0
	public static bool a(c5x A_0)
	{
		foreach (ak1 ak in A_0.l)
		{
			foreach (b0b b0b in ak.Entities)
			{
				if (b0b != A_0 && !b0b.f && !b0b.g)
				{
					c5x c5x = b0b as c5x;
					if (c5x != null)
					{
						if (!c5x.Initialized)
						{
							c5x.y();
						}
						if (c5x.h.b != null)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}
}
