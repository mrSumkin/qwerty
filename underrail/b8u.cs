using System;
using System.Diagnostics;

// Token: 0x02002179 RID: 8569
[bmq("1.0.3.7_ThrowableBarrels", "1.0.3.7", "*", true)]
public sealed class b8u : fg
{
	// Token: 0x0600C93D RID: 51517 RVA: 0x0047189C File Offset: 0x0046FA9C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Layer > 0 && c5x.h.b != null && c5x.h.b.aa().Passive)
					{
						a6p aspect = c5x.GetAspect<a6p>();
						if (aspect != null && aspect.b() != null && c5x.GetAspect<c5i>() == null)
						{
							string text = null;
							if (string.Equals(aspect.b(), "Locale\\Objects\\Destructables\\ExplosiveBarrel", StringComparison.OrdinalIgnoreCase))
							{
								text = "eb";
							}
							else if (string.Equals(aspect.b(), "Locale\\Objects\\Destructables\\Xpbl_BlackOilBarrel", StringComparison.OrdinalIgnoreCase) || string.Equals(aspect.b(), "Locale\\Objects\\Destructables\\BlackOilBarrel", StringComparison.OrdinalIgnoreCase))
							{
								text = "bob";
							}
							else if (string.Equals(aspect.b(), "Locale\\Objects\\Destructables\\Xpbl_AcidBarrel", StringComparison.OrdinalIgnoreCase))
							{
								text = "ac";
							}
							else if (string.Equals(aspect.b(), "Locale\\Objects\\Destructables\\Xpbl_PropaneTank", StringComparison.OrdinalIgnoreCase))
							{
								text = "pb";
							}
							if (text != null)
							{
								c5i c5i = new e6n(c5x);
								((e6n)c5i).a(text);
								c5x.SetAspect<c5i>(c5i);
							}
						}
					}
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
