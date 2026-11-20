using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000680 RID: 1664
[eiz("WM")]
[Serializable]
public sealed class dse : ISerializable
{
	// Token: 0x06002ABB RID: 10939 RVA: 0x000F0624 File Offset: 0x000EE824
	private dse(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<bfc>("WM:L", ref this.a, A_0);
			return;
		}
		if (base.GetType() == typeof(dse))
		{
			this.a = (List<bfc>)A_0.GetValue("_Localities", typeof(List<bfc>));
			return;
		}
		this.a = (List<bfc>)A_0.GetValue("WorldMap+_Localities", typeof(List<bfc>));
	}

	// Token: 0x06002ABC RID: 10940 RVA: 0x000F06BC File Offset: 0x000EE8BC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<bfc>("WM:L", this.a, info);
	}

	// Token: 0x06002ABD RID: 10941 RVA: 0x000F06D0 File Offset: 0x000EE8D0
	public List<bfc> a()
	{
		return this.a;
	}

	// Token: 0x06002ABE RID: 10942 RVA: 0x000F06D8 File Offset: 0x000EE8D8
	public bfc a(string A_0)
	{
		dse.a a = new dse.a();
		a.a = A_0;
		return Enumerable.FirstOrDefault<bfc>(Enumerable.Where<bfc>(this.a, new Func<bfc, bool>(a.a)));
	}

	// Token: 0x06002ABF RID: 10943 RVA: 0x000F0710 File Offset: 0x000EE910
	public dse()
	{
	}

	// Token: 0x04001736 RID: 5942
	private List<bfc> a = new List<bfc>();

	// Token: 0x02000681 RID: 1665
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06002AC1 RID: 10945 RVA: 0x000F072C File Offset: 0x000EE92C
		internal bool a(bfc A_0)
		{
			return string.Equals(A_0.Id, this.a, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04001737 RID: 5943
		public string a;
	}
}
