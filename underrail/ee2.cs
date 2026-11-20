using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Game.Data;

// Token: 0x02000657 RID: 1623
[eiz("MOLI")]
[Serializable]
public sealed class ee2 : ISerializable
{
	// Token: 0x06002934 RID: 10548 RVA: 0x000EB0EC File Offset: 0x000E92EC
	private ee2(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("MOLI:M", typeof(GlobalMap?)) as GlobalMap?);
		di7.ReadDictionary<GlobalMap, Vector3>("MOLI:C", ref this.b, A_0);
		this.c = A_0.GetBoolean("MOLI:F");
		if (ell.a() >= 436)
		{
			di7.ReadDictionary<string, string[]>("MOLI:N", ref this.d, A_0);
			return;
		}
		this.d = new Dictionary<string, string[]>();
	}

	// Token: 0x06002935 RID: 10549 RVA: 0x000EB188 File Offset: 0x000E9388
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("MOLI:M", this.a);
		di7.WriteDictionary<GlobalMap, Vector3>("MOLI:C", this.b, info);
		info.AddValue("MOLI:F", this.c);
		di7.WriteDictionary<string, string[]>("MOLI:N", this.d, info);
	}

	// Token: 0x06002936 RID: 10550 RVA: 0x000EB1E0 File Offset: 0x000E93E0
	public ee2()
	{
	}

	// Token: 0x06002937 RID: 10551 RVA: 0x000EB200 File Offset: 0x000E9400
	public Vector3? a(GlobalMap A_0)
	{
		Vector3 value;
		if (this.b.TryGetValue(A_0, out value))
		{
			return new Vector3?(value);
		}
		return null;
	}

	// Token: 0x06002938 RID: 10552 RVA: 0x000EB230 File Offset: 0x000E9430
	public string[] b(b0b A_0)
	{
		string[] result;
		this.d.TryGetValue(this.a(A_0), out result);
		return result;
	}

	// Token: 0x06002939 RID: 10553 RVA: 0x000EB254 File Offset: 0x000E9454
	public void a(b0b A_0, string[] A_1)
	{
		this.d[this.a(A_0)] = A_1;
	}

	// Token: 0x0600293A RID: 10554 RVA: 0x000EB26C File Offset: 0x000E946C
	public void c(b0b A_0)
	{
		this.d.Remove(this.a(A_0));
	}

	// Token: 0x0600293B RID: 10555 RVA: 0x000EB284 File Offset: 0x000E9484
	private string a(b0b A_0)
	{
		if (A_0 != null && A_0.Area != null)
		{
			return string.Format("{0}_{1}", A_0.Area.y8(), A_0.qe().ToString());
		}
		return string.Empty;
	}

	// Token: 0x04001684 RID: 5764
	public GlobalMap? a;

	// Token: 0x04001685 RID: 5765
	public Dictionary<GlobalMap, Vector3> b = new Dictionary<GlobalMap, Vector3>();

	// Token: 0x04001686 RID: 5766
	public bool c;

	// Token: 0x04001687 RID: 5767
	public Dictionary<string, string[]> d = new Dictionary<string, string[]>();
}
