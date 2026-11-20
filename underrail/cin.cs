using System;

// Token: 0x020017B1 RID: 6065
internal class cin : ak9
{
	// Token: 0x060081A5 RID: 33189 RVA: 0x003692E4 File Offset: 0x003674E4
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new b5x(5)
		};
		A_1 = null;
		A_1 = new wq[0];
		A_2 = null;
	}

	// Token: 0x060081A6 RID: 33190 RVA: 0x00369308 File Offset: 0x00367508
	public override string o6()
	{
		return "DrinkPotion";
	}

	// Token: 0x060081A7 RID: 33191 RVA: 0x00369314 File Offset: 0x00367514
	public override void pw(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			string path = "components\\Containers\\bottle";
			if (ez2.GetItemDefinition<a1k>(path, true) != null)
			{
				fv a_ = new fv(ez2.CreateDefinitonProvider<a1k>(path));
				mk mk = new mk();
				mk.StaticItems.z3(a_, true);
				mk.ym(null, A_0, null);
			}
		}
	}
}
