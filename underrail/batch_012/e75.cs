using System;
using System.Diagnostics;
using Ouroboros.Playfield.References;

// Token: 0x02002198 RID: 8600
[bmq("1.0.1.5_GMSOldMan", "1.0.1.5", "GammaCompound3", false)]
public sealed class e75 : fg
{
	// Token: 0x0600C984 RID: 51588 RVA: 0x00473FCC File Offset: 0x004721CC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("5bfbfa6b-75fc-4a95-ab43-38af664a9a20"), A_1.n("GammaCompound3")).ao() as c5x;
			d2b d2b = new EntityAspectReference<d2b, d2b>(A_1.n("GammaCompound3"), new Guid("333f670f-c227-4dc3-8881-a2efe6006e8d")).ao();
			if (c5x != null && d2b != null && d2b.n() && c5x.t.b != null)
			{
				c5x.t.b.y6()[ddq.ay] = new bt4("freeHostageLocked");
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
