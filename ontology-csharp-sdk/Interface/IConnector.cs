﻿using Common;

namespace Interface
{
    public interface IConnector
    {

        /// <summary>
        /// Returns the current block generation time in seconds
        /// </summary>
        /// <returns></returns>
        int getBlockGenerationTime();

        /// <summary>
        /// Returns the current network block height (most recent block)
        /// </summary>
        /// <returns></returns>
        int getBlockHeight();

        /// <summary>
        /// Returns a JSON string representing the ONT/ONG balance of an address
        /// </summary>
        /// <param name="Address"></param>
        /// <returns></returns>
        string getAddressBalance(string address);

        /// <summary>
        /// Returns the number of nodes connected
        /// </summary>
        /// <returns></returns>
        int getNodeCount();

        /// <summary>
        /// Returns the block height for a given transaction hash
        /// </summary>
        /// <param name="TxHash"></param>
        /// <returns></returns>
        int getBlockHeightByTxHash(string txHash);

        /// <summary>
        /// Returns the hex representation of a block based on block height
        /// </summary>
        /// <param name="blockHeight"></param>
        /// <returns></returns>
        string getBlockHex(int blockHeight);

        /// <summary>
        /// Returns the hex representation of a block based on block hash
        /// </summary>
        /// <param name="blockHash"></param>
        /// <returns></returns>
        string getBlockHex(string blockHash);

        /// <summary>
        /// Returns a JSON string representing a block based on block height
        /// </summary>
        /// <param name="blockHeight"></param>
        /// <returns></returns>
        string getBlockJson(int blockHeight);

        /// <summary>
        /// Returns a JSON string representing a block based on block hash
        /// </summary>
        /// <param name="blockHeight"></param>
        /// <returns></returns>
        string getBlockJson(string blockHash);

        /// <summary>
        /// Returns the hex representation of a transaction based on transaction hash
        /// </summary>
        /// <param name="TxHash"></param>
        /// <returns></returns>
        string getRawTransactionHex(string txHash);

        /// <summary>
        /// Returns a JSON string representing  a transaction based on transaction hash
        /// </summary>
        /// <param name="TxHash"></param>
        /// <returns></returns>
        string getRawTransactionJson(string txHash);

        /// <summary>
        /// Returns a JSON string representing a Smart Contract based on smart contract hash
        /// </summary>
        /// <param name="contractHash"></param>
        /// <returns></returns>
        string getContractJson(string contractHash);

        /// <summary>
        /// Returns a JSON string representing a Smart Contract Event based on block height
        /// </summary>
        /// <param name="blockHeight"></param>
        /// <returns></returns>
        string getSmartCodeEvent(int blockHeight);

        /// <summary>
        /// Returns a JSON string representing a Smart Contract Event based on transaction hash
        /// </summary>
        /// <param name="txHash"></param>
        /// <returns></returns>
        string getSmartCodeEvent(string txHash);


    }
}
