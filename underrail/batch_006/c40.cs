using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001E5F RID: 7775
[eiz("CM1")]
[Serializable]
public sealed class c40 : ISerializable
{
	// Token: 0x0600AC4A RID: 44106 RVA: 0x003F9610 File Offset: 0x003F7810
	private c40(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadDictionary<string, ip>("CM1:C", ref this.a, A_0);
	}

	// Token: 0x0600AC4B RID: 44107 RVA: 0x003F9634 File Offset: 0x003F7834
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteDictionary<string, ip>("CM1:C", this.a, info);
	}

	// Token: 0x0600AC4C RID: 44108 RVA: 0x003F9648 File Offset: 0x003F7848
	public Dictionary<string, ip> b()
	{
		return this.a;
	}

	// Token: 0x0600AC4D RID: 44109 RVA: 0x003F9650 File Offset: 0x003F7850
	public void a(params cfd[] A_0)
	{
		this.a(A_0);
	}

	// Token: 0x0600AC4E RID: 44110 RVA: 0x003F965C File Offset: 0x003F785C
	public void a(IEnumerable<cfd> A_0)
	{
		if (A_0 != null)
		{
			foreach (cfd cfd in A_0)
			{
				ip ip;
				this.a.TryGetValue(cfd.a, out ip);
				if (ip == null || ip.a < (double)cfd.b)
				{
					this.a[cfd.a] = new ip((double)cfd.b, cfd.c, cfd.d);
				}
			}
		}
	}

	// Token: 0x0600AC4F RID: 44111 RVA: 0x003F9704 File Offset: 0x003F7904
	public void a(double A_0)
	{
		foreach (KeyValuePair<string, ip> keyValuePair in Enumerable.ToList<KeyValuePair<string, ip>>(this.a))
		{
			if (keyValuePair.Value.a(A_0))
			{
				this.a.Remove(keyValuePair.Key);
			}
		}
	}

	// Token: 0x0600AC50 RID: 44112 RVA: 0x003F9780 File Offset: 0x003F7980
	public void c()
	{
		foreach (KeyValuePair<string, ip> keyValuePair in Enumerable.ToList<KeyValuePair<string, ip>>(this.a))
		{
			if (keyValuePair.Value.a())
			{
				this.a.Remove(keyValuePair.Key);
			}
		}
	}

	// Token: 0x0600AC51 RID: 44113 RVA: 0x003F97FC File Offset: 0x003F79FC
	public ip a(IList<string> A_0)
	{
		ip ip = null;
		foreach (string key in A_0)
		{
			ip ip2;
			this.a.TryGetValue(key, out ip2);
			if (ip2 != null && (ip == null || ip2.a > ip.a))
			{
				ip = ip2;
			}
		}
		return ip;
	}

	// Token: 0x0600AC52 RID: 44114 RVA: 0x003F9878 File Offset: 0x003F7A78
	public ip b(string A_0)
	{
		ip result;
		this.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x0600AC53 RID: 44115 RVA: 0x003F9898 File Offset: 0x003F7A98
	public void a()
	{
		foreach (KeyValuePair<string, ip> keyValuePair in Enumerable.ToList<KeyValuePair<string, ip>>(this.a))
		{
			if (keyValuePair.Value.c)
			{
				this.a.Remove(keyValuePair.Key);
			}
		}
	}

	// Token: 0x0600AC54 RID: 44116 RVA: 0x003F9914 File Offset: 0x003F7B14
	public bool a(string A_0)
	{
		return this.a.Remove(A_0);
	}

	// Token: 0x0600AC55 RID: 44117 RVA: 0x003F9924 File Offset: 0x003F7B24
	public c40()
	{
	}

	// Token: 0x04004038 RID: 16440
	private Dictionary<string, ip> a = new Dictionary<string, ip>();
}
